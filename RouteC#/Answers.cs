using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_
{
    public class Answers
    {
        public int AnswerID {  get; set; }
        public string AnswerName { get; set; }

        public Answers(int id, string name)
        {
            AnswerID = id;
            AnswerName = name;
        }
    }
}
