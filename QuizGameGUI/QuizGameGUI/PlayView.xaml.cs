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
        int numOfQuestion;
        Question question;

        List<Button> buttons;
        public PlayView(string username)
        {
            InitializeComponent();
            //Accessing the user from the database:
            var user = from usr in UserManager.ListOfUsers
                       where usr.Username == username
                       select usr;


            //Getting a random quiz from our database
            quiz = UserManager.ListOfQuizzes[new Random().Next(UserManager.ListOfQuizzes.Count())];
            
            //Getting the number of question in the current quiz:
            numOfQuestion = quiz.NumOfQuestions;

            //Creating an list of operational buttons:
            buttons = new List<Button>() { btn1,btn2,btn3,btn4};
            //Updating the question counter message:
            questionCountLable.Content = $"Question 0 / {numOfQuestion}";

            //Setting up the first question:
            question = quiz.QuizQuestions[0];

            //Creating a backup list of the optional answers:
            List<string> answer = question.ListOfAnswers;
            
            //Iterating thorough all the buttons - and setting the answers:
            foreach (Button button in buttons)
            {
                int ansIndex = new Random().Next(answer.Count());
                button.Content = answer[ansIndex];
                answer.RemoveAt(ansIndex);
            }

        }

        private void UsersAnswer(object sender, RoutedEventArgs e)
        {
            //Getting the button's name that called this method:
            Button button = sender as Button;

            //Chceking rether the user was right:
            if(button.Content as string == question.Tans) { }
        }
    }
}
