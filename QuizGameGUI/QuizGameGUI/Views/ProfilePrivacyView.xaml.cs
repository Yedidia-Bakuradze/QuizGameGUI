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
    /// Interaction logic for ProfilePrivacyView.xaml
    /// </summary>
    public partial class ProfilePrivacyView : UserControl
    {
        User user;
        public ProfilePrivacyView(string username)
        {
            InitializeComponent();
            user = UserManager.ListOfUsers.First(x => x.Username == username);
        }

        //Changes the mode of the Auto Approve Friend Request:
        private void ChangeAutoApproveFriendRequests(object sender, RoutedEventArgs e)
        {
            autoApproveFriendsState.Text = (autoApproveFriendsState.Text == "Enabled") ? "Disabled" : "Enabled";
        }

        //Changes the mode of the Quiz Public Appearance:
        private void ChangeQuizPublicAppearance(object sender, RoutedEventArgs e)
        {
            switch (quizAppearanceState.Text)
            {
                case "Public":
                    quizAppearanceState.Text = "Friends Only";
                    break;
                case "Friends Only":
                    quizAppearanceState.Text = "Hide";
                    break;
                case "Hide":
                    quizAppearanceState.Text = "Public";
                    break;
                default:
                    break;
            }
        }
    }
}
