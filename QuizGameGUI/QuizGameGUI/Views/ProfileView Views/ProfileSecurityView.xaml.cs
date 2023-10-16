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
    /// Interaction logic for ProfileSecurityView.xaml
    /// </summary>
    public partial class ProfileSecurityView : UserControl
    {
        User user;
        public ProfileSecurityView(string username)
        {
            InitializeComponent();
            user = UserManager.ListOfUsers.First(x => x.Username == username);
            usernameValue.Text = user.Username;
            passwordValue.Text = user.Password;
        }

        //When pressed - The new username field appears or disappears:
        private void changeUsername(object sender, RoutedEventArgs e)
        {
            if(newUsernameTitle.Visibility == Visibility.Visible)
            {
                newUsernameInput.Text = null;
                errorMsg.Content = null;
                newUsernameTitle.Visibility = newUsernameField.Visibility = Visibility.Hidden;
            }
            else
            {
                newUsernameTitle.Visibility = newUsernameField.Visibility = Visibility.Visible;
            }
            SubmitBtnStateChanger();
        }
        //When pressed - The new password field appears or disappears:
        private void changePassword(object sender, RoutedEventArgs e)
        {
            if (newPasswordTitle.Visibility == Visibility.Visible)
            {
                newPasswordInput.Text = null;
                newPasswordCheckInput.Text = null;
                errorMsg.Content = null; 
                newPasswordField.Visibility = newPasswordTitle.Visibility = Visibility.Hidden;
                newPasswordCheckField.Visibility = newPasswordCheckTitle.Visibility = Visibility.Hidden;
            }
            else
            {
                newPasswordField.Visibility = newPasswordTitle.Visibility = Visibility.Visible;
                newPasswordCheckField.Visibility = newPasswordCheckTitle.Visibility = Visibility.Visible;
            }
            SubmitBtnStateChanger();
        }

        //Triggered when the new username field's value is changed: 
        private void usernameFieldChanged(object sender, TextChangedEventArgs e)
        {
            submitBtn.IsEnabled = (!string.IsNullOrEmpty(newUsernameInput.Text));
        }

        //Triggered when the new password fields' value is changed:
        private void passwordFieldChanged(object sender, TextChangedEventArgs e)
        {
            submitBtn.IsEnabled = (!string.IsNullOrEmpty(newPasswordInput.Text) && !string.IsNullOrEmpty(newPasswordCheckInput.Text));
        }
        
        private void SubmitChanges(object sender, RoutedEventArgs e)
        {
            //Updates the username only if the user asked for it:
            if(newUsernameTitle.Visibility == Visibility.Visible)
            {
                //If the username already exists we cant let it to be the new username: 
                if(newUsernameInput == null)
                {
                    errorMsg.Content = "Username field can't be empty";
                }
                else if(UserManager.ListOfUsers.Any(usr=>usr.Username == newUsernameInput.Text))
                {
                    errorMsg.Content = $"Sorry but the username:{newUsernameInput.Text} is already taken";
                }
                else
                {
                    user.Username = newUsernameInput.Text;
                    Finished();
                }
            }
            //Updates the password only if the user asked for it:
            if (newPasswordField.Visibility == Visibility.Visible)
            {
                //The two password fields have to be the same:
                if (newPasswordInput.Text == null || newPasswordCheckInput.Text == null)
                {
                    errorMsg.Content = "Password fields can't be empty";
                }
                else if(newPasswordInput.Text == newPasswordCheckInput.Text)
                {
                    user.Password = newPasswordCheckInput.Text;
                    Finished();
                }
                else
                {
                    errorMsg.Content = "The password fields don't match";
                }
            }
        }

        //Logs back to the HomeView 
        private void Finished()
        {
            Window.GetWindow(this).Content = new HomeView(user.Username);
        }

        //Changes the submit button's state of appearance whether it is needed of not. 
        private void SubmitBtnStateChanger()
        {
            submitBtn.Visibility = ((newUsernameField.Visibility == Visibility.Visible) || (newPasswordField.Visibility == Visibility.Visible)) ? Visibility.Visible : Visibility.Hidden;
        
        }

    }
}
