using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGameGUI
{
    internal class UserManager
    {
        //All users are collated here:
        public static List<User> ListOfUsers { get; } = new List<User>()
        {
            new User("Yedidia","yedidia","1",100),
            new User("Shmuel","shmuel","2",-20),
            new User("Meir","meir","3",40),
            new User("Admin","admin","admin",40),
        };

        public static List<Quiz> ListOfQuizzes { get; } = new List<Quiz>()
        {
            new Quiz("Science","admin"),
            new Quiz("Science","yedidia"),
            new Quiz("Science","meir"),
            new Quiz("Science","shmuel"),
        };
    }
}
