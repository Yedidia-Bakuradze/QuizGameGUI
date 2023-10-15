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
            newUsernameTitle.Visibility = newUsernameField.Visibility= (newUsernameTitle.Visibility == Visibility.Visible)? Visibility.Hidden: Visibility.Visible;
            submitBtn.Visibility = ((newUsernameField.Visibility == Visibility.Visible) ||(newPasswordField.Visibility == Visibility.Visible))? Visibility.Visible: Visibility.Hidden;
        }
        //When pressed - The new password field appears or disappears:
        private void changePassword(object sender, RoutedEventArgs e)
        {
            newPasswordTitle.Visibility = newPasswordCheckTitle.Visibility = newPasswordField.Visibility =
                newPasswordCheckField.Visibility = (newPasswordCheckField.Visibility == Visibility.Hidden)?Visibility.Visible: Visibility.Hidden;
            submitBtn.Visibility = ((newUsernameField.Visibility == Visibility.Visible) || (newPasswordField.Visibility == Visibility.Visible)) ? Visibility.Visible : Visibility.Hidden;
        }

        //Triggered when the new username field's value is changed: 
        private void usernameFieldChanged(object sender, TextChangedEventArgs e)
        {
        }

        //Triggered when the new password fields' value is changed:
        private void passwordFieldChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SubmitChanges(object sender, RoutedEventArgs e)
        {

        }
    }
}
