using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_
{
     class MCQQuestions : Questions
    {
        public MCQQuestions(string header, string body, int mark, Answers[] answers,int rightAnswerId) : base(header, body, mark) 
        {
            AnswerList = answers;
            RightAnswer = rightAnswerId;
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
