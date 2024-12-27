using RouteC_;
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //foreach(WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}
            #endregion

            #region Q2
            //object season;
            //bool IsValid;
            //Console.Write("Enter season name: ");
            //do
            //{
            //    IsValid = Enum.TryParse(typeof(Seas_On), Console.ReadLine(), true, out season);
            //    if(!IsValid)
            //        Console.WriteLine("Enter right name");
            //} while (!IsValid);

            //switch (season)
            //{
            //    case Seas_On.Spring:
            //        Console.WriteLine("march to may"); 
            //        break;
            //    case Seas_On.Summer:
            //        Console.WriteLine("june to august");
            //        break;
            //    case Seas_On.Autumn:
            //        Console.WriteLine("September to November");
            //        break;
            //    case Seas_On.Winter:
            //        Console.WriteLine("December to February");
            //        break;

            //}
            #endregion

            #region Q3
            //Permissons perm = new Permissons();
            //perm = perm ^ Permissons.Read;
            //perm = perm ^ Permissons.Write;
            //if ((perm & Permissons.Read ) == Permissons.Read)
            //    Console.WriteLine("can read? true");
            //else Console.WriteLine("can read? false");

            //if ((perm & Permissons.Write) == Permissons.Write)
            //    Console.WriteLine("can write? true");
            //else Console.WriteLine("can write? false");

            //if ((perm & Permissons.Execute) == Permissons.Execute)
            //    Console.WriteLine("can execute? true");
            //else Console.WriteLine("can excecute? false");

            //if ((perm & Permissons.Delete) == Permissons.Delete)
            //    Console.WriteLine("can delete? true");
            //else Console.WriteLine("can delete? false");
            #endregion

            #region Q4
            //object color;
            //Console.Write("Enter color name: ");
            //bool IsValid  = Enum.TryParse(typeof(Colors), Console.ReadLine(), true, out color);

            //switch (color)
            //{
            //    case Colors.Red:
            //    case Colors.Green: 
            //    case Colors.Blue:
            //        Console.WriteLine("Primary");
            //        break;
            //    default:
            //        Console.WriteLine("not primary");
            //        break;
            //}
            #endregion
        }

    }
}
