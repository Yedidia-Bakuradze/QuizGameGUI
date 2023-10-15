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

namespace QuizGameGUI.Views
{
    /// <summary>
    /// Interaction logic for ProfileView.xaml
    /// </summary>
    public partial class ProfileView : UserControl
    {
        User user;
        public ProfileView(string username)
        {
            InitializeComponent();
            //Getting the user:
            user = UserManager.ListOfUsers.First(x=>x.Username == username);
            //Welcome message initialization:
            welcomeMsg.Content = $"Hello {user.Username}";
            //First initialization:
            mainButton.IsChecked = true ;
            GeneralClicked(this, new RoutedEventArgs(Button.ClickEvent));
        }

        private void GeneralClicked(object sender, RoutedEventArgs e)
        {
            ContentViewer.Content = new ProfileGeneralView(user.Username);
        }

        private void SecurityClicked(object sender, RoutedEventArgs e)
        {
            ContentViewer.Content = new ProfileSecurityView(user.Username);
        }

        private void PrivacyClicked(object sender, RoutedEventArgs e)
        {
            ContentViewer.Content = new ProfilePrivacyView(user.Username);
        }

        private void LikedQuizzesClicked(object sender, RoutedEventArgs e)
        {
           
        }

        private void QuizLibraryClicked(object sender, RoutedEventArgs e)
        {

        }

        private void BackToHomeClicked(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).Content = new HomeView(user.Username);
        }
    }
}
