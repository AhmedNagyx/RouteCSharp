using RouteC_;
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            using MyDBContext context = new MyDBContext();

            #region Create
            //Student student1 = new Student() { FName = "Mohamed", LName = "Yasser", Address = "Alexandria", Age = 21 };
            //Student student2 = new Student() { FName = "Mostafa", LName = "Ibrahim", Address = "Cairo", Age = 21 };

            //context.Add(student1);
            //context.Add(student2);

            //context.SaveChanges();
            #endregion

            #region Retrive
            //var students = context.Student.ToList();
            //foreach (var student in students)
            //{
            //    Console.WriteLine($"{student.FName} {student.LName}");
            //}
            #endregion

            #region Update
            //var studentUpdate = context.Student.FirstOrDefault();
            //if ( studentUpdate != null)
            //{
            //    studentUpdate.Address = "Assuit";
            //    context.SaveChanges();
            //}
            #endregion

            #region Delete
            //var studentDelete = context.Student.Where(x => x.Id == 3 || x.Id == 4).ToList();

            //context.RemoveRange(studentDelete);
            //context.SaveChanges();
            #endregion
        }

    }
}
