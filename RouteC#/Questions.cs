using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_
{
    abstract class Questions
    {
        public string HeaderOfQuestion {  get; set; }
        public string BodyOfQuestion { get; set; }
        public int Mark {  get; set; }
        public Answers[] AnswerList { get; set; }
        public int RightAnswer {  get; set; }
        

        public Questions(string header, string body,int mark)
        {
            HeaderOfQuestion = header;
            BodyOfQuestion = body;
            Mark = mark;
        }

        public abstract void Display();
    }
}
