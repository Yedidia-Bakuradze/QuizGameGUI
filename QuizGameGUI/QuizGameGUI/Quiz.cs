using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGameGUI
{
    internal class Quiz
    {
        public string Category { get; set; }
        public string Description { get; set; }
        public List<Question> QuizQuestions { get; set; }
        public Quiz(string category, string description)
        {
            QuizQuestions = new List<Question>();
            Category = category;
            Description = description;
        }
    }
}
