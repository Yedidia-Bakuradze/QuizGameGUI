using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGameGUI
{
    internal class User
    {
        //User's name:
        public string Name { get; set; }
        //User's username:
        public string Username { get; set; }
        //User's account password:
        public string Password { get; set; }
        //User's total score:
        public int Score { get; }
        //User's personal quiz list:        
        public List<Quiz> PersonalQuizzes { get; set; }

        public User(string name, string username, string password, int score = 0)
        {
            PersonalQuizzes = new List<Quiz>();
            Name = name;
            Username = username;
            Password = password;
            Score = score;
        }

    }
}
