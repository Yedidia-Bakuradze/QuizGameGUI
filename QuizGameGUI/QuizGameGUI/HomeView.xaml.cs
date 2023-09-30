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
    /// Interaction logic for HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        private string username;
        public HomeView(string user)
        {
            InitializeComponent();
            username = user;
            userTitle.Content = $"Hello {username}";
        }

        //Logging out from the account:
        private void Logout(object sender, RoutedEventArgs e)
        {
            Window window = Window.GetWindow(this);
            window.Content = new LobbyView();
        }

        //Redirects the user to the quiz creation view:
        private void CreateQuiz(object sender, RoutedEventArgs e)
        {
            Window window = Window.GetWindow(this);
            window.Content = new QuestionEditorView(username);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
