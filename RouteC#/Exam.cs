using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_
{
    abstract class Exam
    {
        public double TimeInMinutes { get; set; }
        public int NumberOfQuestions { get; set; }
        public Questions[] QuestionsOfExam { get; set; }
        protected Exam(double time, int numberOfQ)
        {
            TimeInMinutes = time;
            NumberOfQuestions = numberOfQ;
            QuestionsOfExam = new Questions[NumberOfQuestions];
        }
        public abstract void ShowExam(Stopwatch stopwatch);
       
    }
}
