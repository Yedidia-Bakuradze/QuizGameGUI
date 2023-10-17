using System;
using System.Collections.Generic;
using System.Linq;
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

namespace QuizGameGUI.Views.HomeView_Views
{
    /// <summary>
    /// Interaction logic for QuizChoiceView.xaml
    /// </summary>
    public partial class QuizChoiceView : UserControl
    {
        User user;
        string resourceDictionary = "ListitemRoundingStyle";
        public QuizChoiceView(string username,string category)
        {
            InitializeComponent();
            user = UserManager.ListOfUsers.First(x => x.Username == username);
            categoryTyep.Text = category;

            //Shows all category related quizzes:
            foreach(Quiz quiz in UserManager.ListOfQuizzes)
            {
                if(quiz.Category == category && quiz.Creator!=user.Username)
                {
                    ListBoxItem item = new ListBoxItem();
                    item.Tag = quiz.Id;
                    item.Content = $"Creator: {quiz.Creator} | Quiz name: {quiz.Name} | Description: {quiz.Description}";
                    item.Style = (Style)FindResource(resourceDictionary);
                    listOfQuizzes.Items.Add(item);
                }
            }

        }
        
        //Start a quiz:
        private void QuizSelected(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem item = (ListBoxItem)listOfQuizzes.SelectedItem;
            Window.GetWindow(this).Content = new QuickPlayView(user.Username,Int32.Parse(item.Tag.ToString()));
        }

        //Return to HomeView:
        private void NavigateHome(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).Content = new HomeView(user.Username);
        }
    }
}
