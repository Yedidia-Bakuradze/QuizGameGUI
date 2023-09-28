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
        public LeaderboardView()
        {
            InitializeComponent();

            var top10users = UserManager.ListOfUsers.OrderByDescending(user => user.Score).Take(10).ToList();
            foreach (var user in top10users)
            {
                listPlayers.Items.Add(user.Username);
                listScores.Items.Add(user.Score);
            }
        }
    }
}
