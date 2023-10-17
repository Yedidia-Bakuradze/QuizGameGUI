using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGameGUI
{
    internal class Quiz
    {
        public string Category { get; set; } = "Other";
        public string Creator { get; set; }
        public string Description { get; set; } = "No description";
        public string Name { get; set; }
        public bool SpeedRunCapable { get; set; } = false;

        //A unique id for each quiz - The source value is in the UserManager class:
        public int Id { get; set; }
        public List<Question> QuizQuestions { get; set; }
        public Quiz(string creator,bool speedRunType=false)
        {
            QuizQuestions = new List<Question>() {
                new Question("What's My Name", "Moshe","Yehuda","Elia","Yedidia","admin"),
                new Question("What's The Capital City of Russia", "TLV","Jerusalem","New-York","Russia","admin"),
                new Question("What's My Last Name", "Elanovitz","Shoshi","Blabla","Bakuradze","admin"),
                new Question("What's My College's Name", "JBL","Giga-El","High-Tech TM","JCT","admin"),

            };
            Creator = creator;
            Id = UserManager.QuizId++;
            SpeedRunCapable = speedRunType;
        }
    }
}
