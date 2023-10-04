using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        int numOfQuestion,questionCount = 0,numOfRightQuestions=0;
        Question question;
        User currentUser;
        List<Button> buttons;
        public PlayView(string username)
        {
            InitializeComponent();
            //Accessing the user from the database:
            currentUser = UserManager.ListOfUsers.First(user => user.Username == username);

            //Getting a random quiz from our database
            quiz = UserManager.ListOfQuizzes[new Random().Next(UserManager.ListOfQuizzes.Count())];
            creatorUsername.Content = quiz.Creator;
            
            //Getting the number of question in the current quiz:
            numOfQuestion = quiz.QuizQuestions.Count();

            //Creating an list of operational buttons:
            buttons = new List<Button>() { btn1,btn2,btn3,btn4};
            QuestionGenerator();
        }

        //Triggered when the user presses the submit answer button:
        private void NextQuestionButtonClicked(object sender, RoutedEventArgs e)
        {
            QuestionGenerator();
        }

        //Triggered when user presses the exit button:
        private void ExitButtonClick(object sender, RoutedEventArgs e)
        {
            ExitQuizMessage();
        }

        private void UsersAnswer(object sender, RoutedEventArgs e)
        {
            //Getting the button's name that called this method:
            Button button = sender as Button;
            //Checking rather the user was right - Changing colors:
            if(button.Content as string == question.Tans)
            {
                currentUser.Score++;
                numOfRightQuestions++;
                rightQuestionsCounter.Content = $"{numOfRightQuestions} / {numOfQuestion} Were right.";
                button.Background = new SolidColorBrush(Colors.Green);
            }
            else
            {
                button.Background= new SolidColorBrush(Colors.Red);
                var rightAnsButton = buttons.First(btn => (string) btn.Content == question.Tans.ToString());
                rightAnsButton.Background = new SolidColorBrush(Colors.Green);
            }

            //Enables the submit buttons' ability:
            submitAnswerButton.IsEnabled = true;
            //Moving foreword with the question index's value:
            questionCount++;
        }

        //This method generates the next questions:
        private void QuestionGenerator()
        {
            submitAnswerButton.Content = (numOfQuestion - questionCount == 1) ? "Finish The Quiz" : "Next Question";
            submitAnswerButton.IsEnabled = false;
            //Setting the colors of the buttons to grey:
            foreach(Button button in buttons)
            {
                button.Background = new SolidColorBrush(Colors.LightGray);
            }

            if (numOfQuestion > questionCount)
            {
                //Updating the question counter message:
                questionCountLable.Content = $"Question {questionCount + 1} / {numOfQuestion}";
                
                //Setting up the first question:
                question = quiz.QuizQuestions[questionCount];

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
            //Leaving the quiz:
            else 
            {
                ExitQuizMessage();
            }
        }

        //A message that would display before the user returns to the home screen:
        private void ExitQuizMessage()
        {
            MessageBox.Show($"You've Finished The Quiz\nYou've answered {numOfRightQuestions} questions right.");
            Window window = Window.GetWindow(this);
            window.Content = new HomeView(currentUser.Username);
        }

    }
}
