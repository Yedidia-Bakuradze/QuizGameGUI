using QuizGameGUI.Views.HomeView_Views;
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
    public partial class QuickPlayView : UserControl
    {
        Quiz quiz;
        int numOfQuestion,questionCount = 0,numOfRightQuestions=0, _timeToPlay=-1;
        Question question;
        User currentUser;
        List<Button> buttons;
        CountdownTimer timer;
        bool isAnswered, speedRunMode=false;
        public QuickPlayView(string username,int quizIndex = -1,int timeToPlay = -1)
        {
            InitializeComponent();
            //Accessing the user from the database:
            currentUser = UserManager.ListOfUsers.First(user => user.Username == username);
            
            //Getting a random quiz from our database - Different user then the player
            //Or special request for a special quiz to play:
            if(quizIndex == -1)
            {
                do
                {
                    quiz = UserManager.ListOfQuizzes[new Random().Next(UserManager.ListOfQuizzes.Count())];
                } while (quiz.Creator == username) ;
            }
            else
            {
                quiz = UserManager.ListOfQuizzes.First(x => x.Id == quizIndex);
            }
            _timeToPlay = timeToPlay;
            //SpeedRun request:
            if(timeToPlay > 0)
            {
                speedRunMode = true;
                Task.Run(() => RunTimer(timeToPlay));
            }


            creatorUsername.Content = $"Made by: {quiz.Creator}";
            
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
            if (speedRunMode)
            {
                SpeedRunFinishedBeforeTime();
            }
            else
            {
                ExitQuizMessage();
            }
        }

        private void UsersAnswer(object sender, RoutedEventArgs e)
        {
            if (speedRunMode)
            {
                //Getting the button's name that called this method:
                Button button = sender as Button;
                //Checking rather the user was right - Changing colors:
                if (button.Content as string == question.Tans)
                {
                    numOfRightQuestions++;
                }
                //Moving foreword with the question index's value:
                questionCount++;
                QuestionGenerator();
            }
            else
            {
                //Let the user choose once only:
                if (!isAnswered)
                {
                    //Getting the button's name that called this method:
                    Button button = sender as Button;
                    //Checking rather the user was right - Changing colors:
                    if (button.Content as string == question.Tans)
                    {
                        numOfRightQuestions++;
                        button.Background = new SolidColorBrush(Colors.Green);
                    }
                    else
                    {
                        button.Background = new SolidColorBrush(Colors.Red);
                        var rightAnsButton = buttons.First(btn => (string)btn.Content == question.Tans.ToString());
                        rightAnsButton.Background = new SolidColorBrush(Colors.Green);
                    }
                    //Indicates that the user already choose an answer:
                    isAnswered = true;

                    //Enables the submit buttons' ability:
                    submitAnswerButton.IsEnabled = true;

                    //Moving foreword with the question index's value:
                    questionCount++;
                }
                else
                {
                    //Since the user already answered - We wont change his choice.
                }
            }
        }

        //This method generates the next questions:
        private void QuestionGenerator()
        {
            isAnswered = false;
            rightQuestionsCounter.Content = $"{numOfRightQuestions} / {numOfQuestion} Were right.";
            submitAnswerButton.Content = (numOfQuestion - questionCount == 1) ? "Finish The Quiz" : "Next Question";
            submitAnswerButton.IsEnabled = false;
            //Setting the colors of the buttons to grey:
            foreach(Button button in buttons)
            {
                button.Background = new SolidColorBrush(Colors.LightGray);
            }
            
            //If there is any more questions left - Continue with the game:
            if (numOfQuestion > questionCount)
            {
                //Updating the question counter message:
                questionCountLable.Content = $"Question {questionCount + 1} / {numOfQuestion}";
                
                //Setting up the first question:
                question = quiz.QuizQuestions[questionCount];
                questionTitle.Content = question.Title;

                //Creating a backup list of the optional answers:
                List<string> answer = new List<string>();
                foreach(string ans in question.ListOfAnswers)
                {
                    answer.Add(ans);
                }

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
                if (speedRunMode)
                {
                    timer.Stop();
                }
                else
                {
                    ExitQuizMessage();
                }
            }
        }

        //A message that would display before the user returns to the home screen:
        private void ExitQuizMessage()
        {
            MessageBox.Show($"You've Finished The Quiz\nYou've answered {numOfRightQuestions} out of {numOfQuestion} questions right.");
            currentUser.Score += numOfRightQuestions;
            Window window = Window.GetWindow(this);
            window.Content = new HomeView(currentUser.Username);
        }
        
        //Exits the game (and stops the timer) when user finishes the quiz early then the timer:
        private void SpeedRunFinishedBeforeTime()
        {
            MessageBox.Show($"Bravo you have finished the whole quiz in {_timeToPlay - timer.GetTimeRemaining()} seconds.\n Leaving you with {timer.GetTimeRemaining()} spare seconds\nYou have answered: {numOfRightQuestions} out of {numOfQuestion} questions right.");
            currentUser.SpeedRunScore += numOfRightQuestions;
            Window window = Window.GetWindow(this);
            window.Content = new HomeView(currentUser.Username);
        }

        //Exits the game when timer goes off:
        private void SpeedRunFinishedInTime()
        {
            MessageBox.Show($"A timer of {_timeToPlay} seconds just went off\nYou've answered {numOfRightQuestions} out of {numOfQuestion} questions right.");
            currentUser.SpeedRunScore += numOfRightQuestions;
            Window window = Window.GetWindow(this);
            window.Content = new HomeView(currentUser.Username);
        }

        //Run the timer based on the given time:
        private void RunTimer(int timeToPlay)
        {
            timer = new CountdownTimer(timeToPlay);
            timer.Start();
            timer.OnTimerElapsed += () =>
            {
                Application.Current.Dispatcher.Invoke(() => SpeedRunFinishedInTime());
            };
            timer.OnTimerStoppedPrematurely += () =>
            {
                Application.Current.Dispatcher.Invoke(() => SpeedRunFinishedBeforeTime());
            };
        }
    }
}
