using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuizGameGUI.Views.ProfileView_Views
{
    /// <summary>
    /// Interaction logic for ProfileMyLikedQuizzesView.xaml
    /// </summary>
    public partial class ProfileMyLikedQuizzesView : UserControl
    {
        string resourceDictionaryFile = "ListitemRoundingStyle";
        User user;
        public ProfileMyLikedQuizzesView(string username)
        {
            InitializeComponent();
            user = UserManager.ListOfUsers.First(x=>x.Username == username);

            foreach(int index in user.LikedQuizzes)
            {
                ListBoxItem item = new ListBoxItem();
                item.Tag = index;
                try
                {
                    item.Content = UserManager.ListOfQuizzes.First(x=>x.Id == index).Category;
                    item.Style = (Style)FindResource(resourceDictionaryFile);
                    listOfQuizzes.Items.Add(item);
                }catch(Exception)
                {
                    continue;
                }
            }

        }

        private void QuizSelected(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem item =  (ListBoxItem)listOfQuizzes.SelectedItem;
            int index = Int32.Parse(item.Tag.ToString());
            Window.GetWindow(this).Content = new QuickPlayView(user.Username,index);
        }
    }
}
