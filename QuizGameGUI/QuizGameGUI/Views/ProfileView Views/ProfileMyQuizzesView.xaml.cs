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

namespace QuizGameGUI.Views.ProfileView_Views
{
    /// <summary>
    /// Interaction logic for ProfileMyQuizzesView.xaml
    /// </summary>
    public partial class ProfileMyQuizzesView : UserControl
    {
        //Current variables:
        User user;
        Quiz quiz;
        Question question;
        string resourceFile = "ListitemRoundingStyle";
        public ProfileMyQuizzesView(string username)
        {
            InitializeComponent();
            user = UserManager.ListOfUsers.First(x=>x.Username == username);
            foreach(Quiz quiz in user.PersonalQuizzes)
            {
                ListBoxItem item = new ListBoxItem();
                item.Style = (Style)FindResource(resourceFile);
                item.Content = quiz.Category;
                item.Tag = quiz.Id;
                listOfQuizzes.Items.Add(item);
            }
        }

        //When quiz is pressed - Its questions would show up:
        private void ShowAssociatedQuestions(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem currentItem = (ListBoxItem)listOfQuizzes.SelectedItem;
            
            //Getting the quiz:
            quiz = UserManager.ListOfQuizzes.Find(x=>x.Id == Int32.Parse(currentItem.Tag.ToString()));
            numOfQuestions.Text = quiz.QuizQuestions.Count().ToString();
            
            //Filling up the questions' list box:
            questionPage.Visibility = Visibility.Visible;
            foreach (Question question in quiz.QuizQuestions)
            {
                ListBoxItem item = new ListBoxItem();
                item.Style =(Style)FindResource(resourceFile);
                item.Content = question.Title;
                listOfQuestions.Items.Add(item);
            }
        }

        //When question is selected - It's values would appear in the question editor page:
        private void ShowQuestionsValues(object sender, SelectionChangedEventArgs e)
        {
            //Clearing the fields:
            questionField.Text = fAns1Field.Text = fAns2Field.Text = fAns3Field.Text = tAnsField.Text = string.Empty;
            questionEditor.Visibility = Visibility.Visible;
            ShowValues();
        }

        //Saves the given values into the proper variables:
        private void SaveChanges(object sender, RoutedEventArgs e)
        {
            question.Title = questionField.Text;
            question.ListOfAnswers[0] = fAns1Field.Text;
            question.ListOfAnswers[1] = fAns2Field.Text;
            question.ListOfAnswers[2] = fAns3Field.Text;
            question.ListOfAnswers[3] = question.Tans = tAnsField.Text;
        }

        //Resets all of the fields:
        private void ResetValues(object sender, RoutedEventArgs e)
        {
            ShowValues();
        }

        //Populates the fields withe the question and answers' values:
        private void ShowValues()
        {
            ListBoxItem item = (ListBoxItem)listOfQuestions.SelectedItem;
            question = quiz.QuizQuestions.First(q => q.Title == (string)item.Content);
            questionField.Text = question.Title;
            fAns1Field.Text = question.ListOfAnswers[0];
            fAns2Field.Text = question.ListOfAnswers[1];
            fAns3Field.Text = question.ListOfAnswers[2];
            tAnsField.Text = question.ListOfAnswers[3];
        }
    }
}
