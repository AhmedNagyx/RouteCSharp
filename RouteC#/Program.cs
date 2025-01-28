using RouteC_;
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Employee Employee = new Employee(1, "Ahmed", 5000.0m, new DateTime(2025, 1, 25), SecurityPrivileges.Developer, 'M');
            //Console.WriteLine(Employee.ToString());
            #endregion

            #region Q2
            //Hiring_Date HD = new Hiring_Date(5,1,2003);
            //Console.WriteLine(HD.ToString());
            #endregion

            #region Q3
            //Employee[] EmpArr = new Employee[3];
            //EmpArr[0] = new Employee
            //    (
            //        1,
            //        "Omar",
            //        10000m,
            //        new DateTime(2025, 1, 24),
            //        SecurityPrivileges.DBA,
            //        'M'
            //    );
            //EmpArr[1] = new Employee
            //    (
            //        2,
            //        "Mai",
            //        10000m,
            //        new DateTime(2024, 1, 20),
            //        SecurityPrivileges.Guest,
            //        'F'
            //    );
            //EmpArr[2] = new Employee
            //    (
            //        3,
            //        "Khalid",
            //        20000m,
            //        new DateTime(2020, 1, 1),
            //        SecurityPrivileges.Officer,
            //        'M'
            //    );
            #endregion

            #region Q4
            //Array.Sort(EmpArr, CompareEmployees);
            //foreach (var x in EmpArr)
            //{
            //    Console.WriteLine(x);
            //}
            #endregion

        }
        public static int CompareEmployees(Employee e1, Employee e2)
        {
             return e1.HiringDate.CompareTo(e2.HiringDate);
        }
       
    }

   
}
