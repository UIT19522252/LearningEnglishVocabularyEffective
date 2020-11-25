using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;

namespace StartMenu
{
    public class Question
    {
        public string answer;
        public string question;
        public Question()
        {
            answer = question = "None";
        }
        public Question(string a, string b)
        {
            question = a;
            answer = b;
        }
    }
}
