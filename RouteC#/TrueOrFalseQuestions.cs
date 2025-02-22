using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_
{
    class TrueOrFalseQuestions : Questions
    {
        public TrueOrFalseQuestions(string header, string body, int mark, int rightAnswer) : base(header, body, mark)
        {
            AnswerList = new Answers[] 
            { 
                new Answers(1,"True"), 
                new Answers(2,"False")
            };
            RightAnswer = rightAnswer;
        }
        public override void Display()
        {
            Console.WriteLine($"{HeaderOfQuestion}: {BodyOfQuestion} (Mark {Mark})");
            foreach (var answer in AnswerList)
            {
                Console.WriteLine($"{answer.AnswerID}.{answer.AnswerName}");
            }
            Console.WriteLine();
        }
    }
}
