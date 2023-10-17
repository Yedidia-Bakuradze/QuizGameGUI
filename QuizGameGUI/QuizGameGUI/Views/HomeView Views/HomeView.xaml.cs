using QuizGameGUI.Views;
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

namespace QuizGameGUI
{
    /// <summary>
    /// Interaction logic for HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        private string username;
        public HomeView(string user)
        {
            InitializeComponent();
            username = user;
            userTitle.Content = $"Hello {username}";

            mainButton.IsChecked = true ;
            ViewControl.Content = new DiscoverView(username);
        }

        //Logging out from the account:
        private void Logout(object sender, RoutedEventArgs e)
        {
            Window window = Window.GetWindow(this);
            window.Content = new LobbyView();
        }

        //Redirects the user to the quiz creation view:
        private void CreateQuiz(object sender, RoutedEventArgs e)
        {
            ViewControl.Content = new QuestionEditorView(username);
        }

        //Redirects the user to play a quiz:
        private void StartQuiz(object sender, RoutedEventArgs e)
        {
            ViewControl.Content = new DiscoverView(username);
        }

        private void ShowLeaderboard(object sender, RoutedEventArgs e)
        {
            ViewControl.Content = new LeaderboardView();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).Content = new ProfileView(username);
        }
    }
}
