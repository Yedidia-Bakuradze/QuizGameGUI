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
    /// Interaction logic for PlayView.xaml
    /// </summary>
    public partial class PlayView : UserControl
    {
        Quiz quiz;
        public PlayView(string username)
        {
            InitializeComponent();
            //Accessing the user from the database:
            var user = from usr in UserManager.ListOfUsers
                       where usr.Username == username
                       select usr;
            //Getting a random quiz from our database
            int index = new Random().Next(UserManager.ListOfQuizzes.Count);
            quiz = UserManager.ListOfQuizzes[index];
        }

        private void UsersAnswer(object sender, RoutedEventArgs e)
        {
            //Getting the button's name that called this method:

        }
    }
}
