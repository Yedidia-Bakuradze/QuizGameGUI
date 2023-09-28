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
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        //Connects the user to the system:
        private void UserLogin(object sender, RoutedEventArgs e)
        {
            //Checks if the given user exists:
            try
            {
                var currentUser = UserManager.ListOfUsers.First(user => user.Username == usernameField.Text);
                //Checks if the password is correct:
                if (currentUser.Password != passwordField.Text)
                {
                    //Making suer that 2 types of error aren't shown up at the same time:
                    signupRediraction.Visibility = Visibility.Hidden;

                    //Showing up the current error:
                    errorMessage.Content = "Wrong password!";
                    errorMessage.Visibility = Visibility.Visible;
                    passwordResetRediraction.Visibility = Visibility.Visible;
                }
                //If everything is fine - Continue to the home page:
                else
                {
                    Window window = Window.GetWindow(this);
                    window.Content = new HomeView(currentUser.Username);
                }
                //If the user wasn't found:
            }
            catch (InvalidOperationException ex)
            {
                //Making suer that 2 types of error aren't shown up at the same time:
                passwordResetRediraction.Visibility = Visibility.Hidden;

                //Showing up the current error:
                errorMessage.Content = "User doesn't exist!";
                errorMessage.Visibility = Visibility.Visible;
                signupRediraction.Visibility = Visibility.Visible;
            }
            //For any other exceptions:
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        //Check whether all the textboxes are filled:
        private void TextboxTextChanged(object sender, TextChangedEventArgs e)
        {
            if (usernameField.Text != null && passwordField.Text != null) { submitButton.IsEnabled = true; }
        }

        //Redirecting the user to the signup view:
        private void SignupButton(object sender, RoutedEventArgs e)
        {
            Window window = Window.GetWindow(this);
            window.Content = new SignupView();
        }

        //If the user wants to reset its password:
        private void PasswordResetButton(object sender, RoutedEventArgs e)
        {
            Window window = Window.GetWindow(this);
            window.Content = new PasswordResetView(usernameField.Text);
        }
    }
}

