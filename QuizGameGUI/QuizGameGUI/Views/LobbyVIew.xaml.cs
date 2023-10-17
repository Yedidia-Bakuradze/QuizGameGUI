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
    /// Interaction logic for LobbyVIew.xaml
    /// </summary>
    public partial class LobbyView : UserControl
    {
        public LobbyView()
        {
            InitializeComponent();

            mainButton.IsChecked = true;
            Lobby.Content = new LoginView();
        }

        //Redirect pops up in the ContentControl the Registration form:
        private void Signup(object sender, RoutedEventArgs e)
        {
            Lobby.Content = new SignupView();
        }

        //Redirect pops up in the ContentControl the Login form:
        private void Login(object sender, RoutedEventArgs e)
        {
            Lobby.Content = new LoginView();
        }

        //Exits the app:
        private void ExitApp(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
