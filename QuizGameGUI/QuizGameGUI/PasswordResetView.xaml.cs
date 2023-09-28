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
    /// Interaction logic for PasswordResetView.xaml
    /// </summary>
    public partial class PasswordResetView : UserControl
    {
        string currentUsername;
        public PasswordResetView(string username)
        {
            InitializeComponent();
            currentUsername = username;
        }

        //Changing user's password
        private void Submit(object sender, RoutedEventArgs e)
        {
            //Check whether the passwords are the same or not:
            if (newPasswordField.Text == newPasswordFieldAgain.Text)
            {
                var currentUser = UserManager.ListOfUsers.First((user) => user.Username == currentUsername);
                currentUser.Password = newPasswordField.Text;
                Window window = Window.GetWindow(this);
                window.Content = new LobbyView();
            }
            //If the passwords aren't the same:
            else
            {
                errorMessage.Visibility = Visibility.Visible;
            }
        }

        //Enables the button only when both fields are full and not empty:
        private void TextboxValueChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(newPasswordField.Text) && !string.IsNullOrEmpty(newPasswordFieldAgain.Text)) { submitButton.IsEnabled = true; }
            else { submitButton.IsEnabled = false; }
        }
    }
}

