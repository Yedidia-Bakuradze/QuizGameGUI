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
    /// Interaction logic for QuestionEditorView.xaml
    /// </summary>
    public partial class QuestionEditorView : UserControl
    {
        private int questionCount = 1;
        private int NumOfQuestions;
        private string Username;
        private Quiz quiz;
        public QuestionEditorView(string username, string type, string description, int numOfQuestions)
        {
            InitializeComponent();

            Username = username;
            NumOfQuestions = numOfQuestions;
            quiz = new Quiz(type, description);

            //Writes down on which question we are:
            ShowCount();
        }
        public void ShowCount()
        {
            questionCounterField.Content = $"Question Number: {questionCount} / {NumOfQuestions}";
        }

        //Submits the questions and adds it to the list:
        private void AddQuestion(object sender, RoutedEventArgs e)
        {
            quiz.QuizQuestions.Add(new Question(theQuestionFiled.Text, fAns1Field.Text, fAns2Field.Text, fAns3Field.Text, tAnsField.Text, Username));
            questionCount++;
            theQuestionFiled.Text = null;
            fAns1Field.Text = null;
            fAns2Field.Text = null;
            fAns3Field.Text = null;
            tAnsField.Text = null;
            ShowCount();
            //Ones the user finished adding question - he shall go back to the home screen:
            if (questionCount > NumOfQuestions)
            {
                MessageBox.Show($"You've added {NumOfQuestions} questions successful.");

                //Identifying the user and adding the quiz to its database of quizzes:
                User currentUser = UserManager.ListOfUsers.First(user => user.Username == Username);
                currentUser.PersonalQuizzes.Add(quiz);

                //Switching back to the home page:
                Window window = Window.GetWindow(this);
                window.Content = new HomeView(Username);
            }
        }

        //Lets the user to continues only when all the fields are full:
        private void TextboxValueChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(theQuestionFiled.Text) && !string.IsNullOrEmpty(fAns1Field.Text) && !string.IsNullOrEmpty(fAns2Field.Text) && !string.IsNullOrEmpty(fAns3Field.Text)
                && !string.IsNullOrEmpty(tAnsField.Text)) { continueButton.IsEnabled = true; }
            else { continueButton.IsEnabled = false; }
        }
    }
}
