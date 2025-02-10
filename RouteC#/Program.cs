using RouteC_;
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1.ToString());

            Duration D2 = new Duration(3600);
            Console.WriteLine(D2.ToString());

            Duration D3 = new Duration(7800);
            Console.WriteLine(D2.ToString());

            Duration D4 = new Duration(666);
            Console.WriteLine(D4.ToString());
            Console.WriteLine();

            D3 = D1 + D2;
            Console.WriteLine($"+ : {D3}");

            D3 = D1 + 7800;
            Console.WriteLine($"+7800 : {D3}");

            D3 = 666 + D3;
            Console.WriteLine($"+666 : {D3}");

            D3 = ++D1;
            Console.WriteLine($"++ : {D3}");

            D3 = --D2;
            Console.WriteLine($"-- : {D3}");

            D1 = D1 - D2;
            Console.WriteLine($"- : {D3}");
            Console.WriteLine();

            if (D1 > D2)
                Console.WriteLine("D1 > D2");
            else Console.WriteLine("D1 !> D2");

            if (D1 <= D2)
                Console.WriteLine("D1 <= D2");
            else Console.WriteLine("D1 !<= D2");

            if (D1)
                Console.WriteLine("D1 exists");
            else Console.WriteLine("D1 is null");

            DateTime Obj = (DateTime)D1;
            Console.WriteLine("D1 to DateTime: " + Obj);
        }

    }
}
