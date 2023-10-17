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
    /// Interaction logic for ProfileGeneralView.xaml
    /// </summary>
    public partial class ProfileGeneralView : UserControl
    {
        User user;
        public ProfileGeneralView(string username)
        {
            InitializeComponent();
            
            //Getting the user:
            user = UserManager.ListOfUsers.First(x => x.Username == username);

            //Filling the fields:
            
            nameValue.Text = user.Name;
            scoreValue.Text = user.Score.ToString();
            //followersValue.Text = user.Followers.ToString();
            //quizPlayedValue.Text = user.numPlayedGames.ToString();
            quizCreatedValue.Text = user.PersonalQuizzes.Count().ToString();
            //followingsValue.Text = user.Followings.ToString();
        }
    }
}
