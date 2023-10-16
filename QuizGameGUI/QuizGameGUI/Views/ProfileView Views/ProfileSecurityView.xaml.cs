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
        private void ShowChangeUsernameField(object sender, RoutedEventArgs e)
        {
            if(newUsernameTitle.Visibility == Visibility.Visible)
            {
                newUsernameInput.Text = null;
                newUsernameTitle.Visibility = newUsernameField.Visibility = Visibility.Hidden;
            }
            else
            {
                newUsernameTitle.Visibility = newUsernameField.Visibility = Visibility.Visible;
            }
            SubmitBtnStateChanger();
        }
        //When pressed - The new password field appears or disappears:
        private void ShowChangePasswordField(object sender, RoutedEventArgs e)
        {
            if (newPasswordTitle.Visibility == Visibility.Visible)
            {
                newPasswordInput.Text = null;
                newPasswordCheckInput.Text = null;
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
            if (ChangePassword() || ChangeUsername())
                Finished();
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

        //Changes the username of the current player - and returns whether the change happened or not:
        private bool ChangeUsername()
        {
            if (newUsernameField.Visibility == Visibility.Visible)
            {
                //No duplicate usernames:
                if (UserManager.ListOfUsers.Any(x => x.Username == newUsernameInput.Text))
                {
                    errorMsg.Content = $"Sorry but the username: {newUsernameInput.Text} is been taken.";
                    return false;
                }
                else
                {
                    user.Username = newUsernameInput.Text;
                    return true;
                }
            }
            else { return false; }
        }

        private bool ChangePassword()
        {
            if (newPasswordField.Visibility == Visibility.Visible)
            {
                if (newPasswordCheckInput.Text != newPasswordInput.Text)
                {
                    errorMsg.Content = "The values on both fields have to be identical.";
                    return false;
                }
                else
                {
                    user.Password = newPasswordInput.Text;
                    return true;
                }
            }
            else { return false; }
        }
    }
}
