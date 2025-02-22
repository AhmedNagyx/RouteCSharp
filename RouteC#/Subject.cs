using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_
{
    class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam SubjectExam { get; set; }

        public Subject(int id, string name)
        {
            SubjectId = id;
            SubjectName = name;
            
        }
        public void CreateExam()
        {
            Console.WriteLine();
            Console.Write("Enter Exam Type Id => 1 for Final, 2 for Practical): ");
            int examType = int.Parse(Console.ReadLine());

            Console.Write("Enter Exam Duration in minutes: ");
            double time = double.Parse(Console.ReadLine());

            Console.Write("Enter Number of Questions: ");
            int numQuestions = int.Parse(Console.ReadLine());

            if (examType == 1)
            {
                SubjectExam = new FinalExam(time, numQuestions);
            }
            else if (examType == 2)
            {
                SubjectExam = new PracticalExam(time, numQuestions);
            }
            else
            {
                Console.WriteLine("invalid");
            }

            for (int i = 0; i < numQuestions; i++)
            {
                Console.WriteLine();
                Console.Write("Enter Question Header: ");
                string header = Console.ReadLine();

                Console.Write("Enter Question Body: ");
                string body = Console.ReadLine();

                Console.Write("Enter Question Mark: ");
                int mark = int.Parse(Console.ReadLine());

                Console.Write("Enter Question Type => 1 for True/False, 2 for MCQ): ");
                int questionsType = int.Parse(Console.ReadLine());

                Questions question = null;

                if (questionsType == 1)// t/f
                {
                    if (SubjectExam is PracticalExam)
                    {
                        Console.WriteLine("Practical Exam only allows MCQ questions");
                        i--;
                        continue;
                    }
                   
                     Console.Write("Enter Correct Answer (1 for True, 2 for False): ");
                     int rightAnswerId = int.Parse(Console.ReadLine());
                     question = new TrueOrFalseQuestions(header, body, mark, rightAnswerId);
                    
                }

                else if (questionsType == 2) // mcq
                {
                    Console.Write("Enter number of choices: ");
                    int numChoices = int.Parse(Console.ReadLine());
                    Answers[] answers = new Answers[numChoices];

                    for (int j = 0; j < numChoices; j++)
                    {
                        Console.Write($"Enter Choice {j + 1}: ");
                        string choiceText = Console.ReadLine();
                        answers[j] = new Answers(j + 1, choiceText);
                    }

                    Console.Write("Enter Correct Answer ID: ");
                    int rightAnswerId = int.Parse(Console.ReadLine());
                    question = new MCQQuestions(header, body, mark, answers, rightAnswerId);
                }
                    
                SubjectExam.QuestionsOfExam[i] = question;
               
                Console.WriteLine();
            }

        }
        
    }
}
