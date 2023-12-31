﻿using System;
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
        private string Username;
        private Quiz quiz;
        public QuestionEditorView(string username)
        {
            InitializeComponent();

            Username = username;
            quiz = new Quiz(username);

            //Writes down on which question we are:
            ShowCount();
        }
        public void ShowCount()
        {
            questionCounterField.Content = $"Question Number: {questionCount}";
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
        }

        //Lets the user to continues only when all the fields are full:
        private void TextboxValueChanged(object sender, TextChangedEventArgs e)
        {
            //Set the submit button to be available if all the fields are full:
            if (!string.IsNullOrEmpty(theQuestionFiled.Text) && !string.IsNullOrEmpty(fAns1Field.Text) && !string.IsNullOrEmpty(fAns2Field.Text) && !string.IsNullOrEmpty(fAns3Field.Text)
                && !string.IsNullOrEmpty(tAnsField.Text)) { nextQuestionButton.IsEnabled = true; quizDoneButton.IsEnabled = true; }
            else { nextQuestionButton.IsEnabled = false; quizDoneButton.IsEnabled = false; }
        }

        private void QuizDone(object sender, RoutedEventArgs e)
        {
            //Adds the last question to the quiz:
            quiz.QuizQuestions.Add(new Question(theQuestionFiled.Text, fAns1Field.Text, fAns2Field.Text, fAns3Field.Text, tAnsField.Text, Username));

            //Adding the quiz to the global quiz list:
            UserManager.ListOfQuizzes.Add(quiz);


            //Sum up message:
            MessageBox.Show($"Description: {quiz.Category}\nYou've successful added {questionCount} questions.");

            //Make all other UI components except centeredStackPanel invisible
            foreach (UIElement element in questionEditor.Children)
            {
                if (element is FrameworkElement frameworkElement && frameworkElement.Name != "finalField")
                {
                    frameworkElement.Visibility = Visibility.Collapsed;
                }
            }

            // Make the centeredStackPanel visible
            finalField.Visibility = Visibility.Visible;
        }

        //Final quiz submit:
        private void SubmitChanges(object sender, RoutedEventArgs e)
        {
            quiz.Category = ((ListBoxItem)catergoryList.SelectedItem).Content as string;
            quiz.Name = quizNameField.Text;
            quiz.Description = quizDiscription.Text;


            quiz.SpeedRunCapable = quiz.QuizQuestions.Count() > 20;
            //Sum up message:
            MessageBox.Show($"Theme: {quiz.Category}\nYou've successful added {questionCount} questions.");

            //Adding the quiz to the global quiz list:
            UserManager.ListOfQuizzes.Add(quiz);
            //Identifying the user and adding the quiz to its database of quizzes:
            User currentUser = UserManager.ListOfUsers.First(user => user.Username == Username);
            currentUser.PersonalQuizzes.Add(quiz);

            //Switching back to the home page:
            Window window = Window.GetWindow(this);
            window.Content = new HomeView(Username);
        }

        
        //Checks if the user fill all the required fields:
        private void CategorySelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BtnEnable();
        }
        private void QuizNameValueChanged(object sender, TextChangedEventArgs e)
        {
            BtnEnable();
        }

        private void BtnEnable()
        {
            btnSubmit.IsEnabled = !string.IsNullOrEmpty(quizNameField.Text) && catergoryList.SelectedItems.Count !=0 && !string.IsNullOrEmpty(quizDiscription.Text);
        }

    }
}
