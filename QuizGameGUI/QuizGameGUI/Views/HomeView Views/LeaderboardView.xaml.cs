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
    /// Interaction logic for LeaderboardView.xaml
    /// </summary>
    public partial class LeaderboardView : UserControl
    {
        enum Modes { Regular,Speedrun};
        Modes mode = Modes.Regular;
        List<User> top10users;
        public LeaderboardView()
        {
            InitializeComponent();
            ShowData();
        }

        //Changes the mode of appearance:
        private void btnChangeMode_Click(object sender, RoutedEventArgs e)
        {
            mode = (mode == Modes.Regular)? Modes.Speedrun: Modes.Regular;
            btnChangeMode.Content = (mode == Modes.Regular) ? "Speedrun Mode" : "Regular Mode";
            ShowData();
        }

        //Shows the data according to the current mode:
        private void ShowData()
        {
            //Reset values:
            listScores.Items.Clear(); 
            listPlayers.Items.Clear();
            
            //Select players based on the show mode:
            top10users = (mode == Modes.Regular)?UserManager.ListOfUsers.OrderByDescending(user => user.Score).Take(10).ToList():
                UserManager.ListOfUsers.OrderByDescending(user => user.SpeedRunScore).Take(10).ToList();
            
            //Add the values to the lists:
            foreach (var user in top10users)
            {
                listPlayers.Items.Add(user.Username);
                listScores.Items.Add((mode == Modes.Regular)?user.Score:user.SpeedRunScore);
            }
        }
    }
}
