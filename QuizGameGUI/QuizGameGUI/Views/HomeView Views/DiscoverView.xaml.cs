using QuizGameGUI.Views.HomeView_Views;
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
    /// Interaction logic for DiscoverView.xaml
    /// </summary>
    public partial class DiscoverView : UserControl
    {
        string _username;
        public DiscoverView(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void QuickPlay(object sender, RoutedEventArgs e)
        {
            Window window = Window.GetWindow(this);
            window.Content = new QuickPlayView(_username);
        }

        private void StartScience(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).Content = new QuizChoiceView(_username, topicA.Text);
        }

        private void StartMathematics(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).Content = new QuizChoiceView(_username, topicB.Text);
        }

        private void StartHistory(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).Content = new QuizChoiceView(_username, topicC.Text);
        }

        private void StartProgramming(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).Content = new QuizChoiceView(_username, topicD.Text);
        }
    }
}
