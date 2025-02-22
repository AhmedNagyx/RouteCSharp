using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_
{
    class PracticalExam : Exam
    {
        public PracticalExam(double time, int numberOfQ) : base(time, numberOfQ)
        {

        }

        public override void ShowExam(Stopwatch stopwatch)
        {
            foreach (var question in QuestionsOfExam)
            {
                if (stopwatch.Elapsed.TotalMinutes >= TimeInMinutes)
                {
                    Console.WriteLine("Time is up! can't show more questions");
                    break;
                }

                question.Display();
                Console.Write("Your Answer ID: ");
                int userAnswer = int.Parse(Console.ReadLine());

                int displayId = -1;

                
                foreach (var answer in question.AnswerList)
                {
                    if (answer.AnswerID == question.RightAnswer)
                    {
                        displayId = answer.AnswerID;
                        break; 
                    }
                }

                Console.WriteLine($"Correct Answer: {displayId}");
                Console.WriteLine();
            }
        }
    }
}
