using QuizGameGUI.Views;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Demo quizzes
            Quiz a = new Quiz("yedidia");
            User au = UserManager.ListOfUsers.First(x=>x.Username =="yedidia");
            a.Category = "History";
            a.Name = "First";
            a.SpeedRunCapable = true;
            au.SpeedRunScore = 100;
            UserManager.ListOfQuizzes.Add(a);
            au.PersonalQuizzes.Add(a);

            Quiz b = new Quiz("admin");
            User bu = UserManager.ListOfUsers.First(x=>x.Username =="admin");
            b.Category = "Science";
            b.Name = "First";
            bu.SpeedRunScore = 8;
            UserManager.ListOfQuizzes.Add(b);
            bu.PersonalQuizzes.Add(b);

            Quiz c = new Quiz("meir");
            c.Category = "Programming";
            User cu = UserManager.ListOfUsers.First(x=>x.Username =="meir");
            c.Name = "First";
            cu.SpeedRunScore = 2;
            UserManager.ListOfQuizzes.Add(c);
            cu.PersonalQuizzes.Add(c);

            Quiz d = new Quiz("shmuel");
            d.Category = "Mathematics";
            User du = UserManager.ListOfUsers.First(x=>x.Username =="shmuel");
            d.Name = "First";
            du.SpeedRunScore = 48;
            UserManager.ListOfQuizzes.Add(d);
            du.PersonalQuizzes.Add(d);

            Window windows = Window.GetWindow(this);
            windows.Content = new LobbyView();
        
        }


        //Provides the window movement:
        private void OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
    }
}
