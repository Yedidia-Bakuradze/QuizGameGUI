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
    /// Interaction logic for LobbyVIew.xaml
    /// </summary>
    public partial class LobbyView : UserControl
    {
        public LobbyView()
        {
            InitializeComponent();
            Lobby.Content = new LoginView();
        }
        private void Signup(object sender, RoutedEventArgs e)
        {
            Lobby.Content = new SignupView();
        }

        private void Login(object sender, RoutedEventArgs e)
        {
            Lobby.Content = new LoginView();
        }


    }
}
