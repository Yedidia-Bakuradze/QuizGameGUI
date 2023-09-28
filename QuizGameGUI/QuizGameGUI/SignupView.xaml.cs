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
    /// Interaction logic for SignupView.xaml
    /// </summary>
    public partial class SignupView : UserControl
    {
        public SignupView()
        {
            InitializeComponent();
        }

        //Adding the new user to our database of users - Only if he isn't signed up already:
        private void SubmitSignup(object sender, RoutedEventArgs e)
        {

            //If the user was found - Don't create a new one instead - redirect the user to the login page
            try
            {
                var tmpUser = UserManager.ListOfUsers.First(user => user.Username == usernameField.Text);
                loginRediraction.Visibility = Visibility.Visible;
            }
            catch (InvalidOperationException)
            {
                User usr = new User(nameField.Text, usernameField.Text, passwordField.Text);
                UserManager.ListOfUsers.Add(usr);
                Window window = Window.GetWindow(this);
                window.Content = new LobbyView();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        //If the user has an account - He can login in the login view:
        private void Login(object sender, RoutedEventArgs e)
        {
            Window window = Window.GetWindow(this);
            window.Content = new LoginView();
        }

        //Checks if all the fields are filled:
        private void TextboxValueChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(usernameField.Text) && !string.IsNullOrEmpty(nameField.Text) && !string.IsNullOrEmpty(passwordField.Text)) { submitButton.IsEnabled = true; }
            else { submitButton.IsEnabled = false; }

        }

    }
}
