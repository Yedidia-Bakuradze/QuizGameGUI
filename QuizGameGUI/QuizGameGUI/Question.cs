using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGameGUI
{
    internal class Question
    {
        public string Owner { get; set; }
        public string Title { get; set; }
        public List<string> ListOfAnswers { get; set; }
        public string Tans { get; set; }

        public Question(string title, string fans1, string fans2, string fans3, string tans, string username)
        {
            Owner = username;
            Title = title;
            Tans = tans;
            ListOfAnswers = new List<string>() { fans1, fans2, fans3 ,tans};
        }
    }
}
