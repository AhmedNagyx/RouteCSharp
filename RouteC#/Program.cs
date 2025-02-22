using RouteC_;
using System;
using System.Diagnostics;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Subject Name: ");
            string subjectName = Console.ReadLine();

            Console.Write("Enter Subject ID: ");
            int subjectId = int.Parse(Console.ReadLine());
            
            Subject subject = new Subject(subjectId, subjectName);
            subject.CreateExam();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            subject.SubjectExam.ShowExam(stopwatch);
            stopwatch.Stop();

            Console.WriteLine();
            Console.WriteLine($"Time Taken: {stopwatch.Elapsed}");
        }

    }
}
