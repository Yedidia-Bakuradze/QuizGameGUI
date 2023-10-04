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
            new User("Yedidia","Yedidia Bakuradze","1",100),
            new User("Shmuel","Shmuel Kaplan","2",-20),
            new User("Meir","Meir Crombie","3",40),
            new User("admin","admin","admin",40),
        };

        public static List<Quiz> ListOfQuizzes { get; } = new List<Quiz>()
        {
            new Quiz("Science",1,"Admin"),
        };
    }
}
