using RouteC_;
using System;
using System.Drawing;
using System.Runtime.Intrinsics.X86;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //_3DPoint point = new _3DPoint(10, 10, 10);
            //Console.WriteLine(point.ToString());

            //_3DPoint P1 = _3DPoint.ReadPoint("P1");
            //_3DPoint P2 =  _3DPoint.ReadPoint("P2");

            //Console.WriteLine(P1);
            //Console.WriteLine(P2);

            ////Try to use ==
            ////If(P1 == P2)   Does it work properly? 
            ////-> won't work as it compares references not values.
            ///

            //_3DPoint[] points = new _3DPoint[]
            //{
            //    new _3DPoint(3, 2, 3),
            //    new _3DPoint(1, 4, 5),
            //    new _3DPoint(3, 1, 2),
            //};
            //_3DPoint[] sortedPoints = points.OrderBy(p => p.x).ThenBy(p => p.y).ToArray();

            //Console.WriteLine("Sorted Points:");
            //foreach (_3DPoint point in sortedPoints)
            //{
            //    Console.WriteLine(point);
            //}


            #endregion


            #region Q2

            ////so i dont use instance i make the method static, with instance i dont use static
            //Console.WriteLine($"Addition: {Maths.Add(4,2)}");
            //Console.WriteLine($"Subtraction: {Maths.Subtract(4, 2)}");
            //Console.WriteLine($"Multiplication: {Maths.Multiply(4, 2)}");
            //Console.WriteLine($"Division: {Maths.Divide(4, 2)}");
            #endregion

            #region Q3 
            //Duration D1 = new Duration(1, 10, 15);
            //Console.WriteLine(D1.ToString());

            //Duration D2 = new Duration(3600);
            //Console.WriteLine(D2.ToString());
           
            //Duration D3 = new Duration(7800);
            //Console.WriteLine(D3.ToString());
            
            //Duration D4 = new Duration(666);
            //Console.WriteLine(D4.ToString());
            #endregion

        }

    }
}
