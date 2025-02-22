using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_
{
    class FinalExam : Exam
    {
        public FinalExam(double time, int numberOfQ) : base(time, numberOfQ)
        {

        }

        public override void ShowExam(Stopwatch stopwatch)
        {
            int score = 0;


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

                if (userAnswer == question.RightAnswer)
                {
                    score += question.Mark;
                }
  
            }

            Console.WriteLine($"Your Grade: {score}");
        }
    }
    
}
