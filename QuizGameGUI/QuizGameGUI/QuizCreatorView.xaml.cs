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
    /// Interaction logic for QuizCreatorView.xaml
    /// </summary>
    public partial class QuizCreatorView : UserControl
    {
        private string Username;
        public QuizCreatorView(string username)
        {
            InitializeComponent();
            Username = username;
        }

        private void TextboxValueChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(discriptionField.Text) && !string.IsNullOrEmpty(numOfQuestionsField.Text) && listOfTypes.SelectedItem != null) { startButton.IsEnabled = true; }
            else { startButton.IsEnabled = false; }
        }

        private void ItemSelected(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(discriptionField.Text) && !string.IsNullOrEmpty(numOfQuestionsField.Text) && ((ListBoxItem)listOfTypes.SelectedItem).Content != null) { startButton.IsEnabled = true; }
            else { startButton.IsEnabled = false; }
        }

        private void StartButtonActivated(object sender, RoutedEventArgs e)
        {
            int numOfQuestions;
            if (!int.TryParse(numOfQuestionsField.Text, out numOfQuestions))
            {
                errorMessage.Visibility = Visibility.Visible;
            }
            else
            {
                Window window = Window.GetWindow(this);
                window.Content = new QuestionEditorView(Username, ((ListBoxItem)listOfTypes.SelectedItem).Content.ToString(), discriptionField.Text, numOfQuestions);
            }
        }
    }
}
