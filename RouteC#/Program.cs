using System;
using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Pass by Value: The method gets a copy of the variable.
            //   Changes made inside the method do not affect the original value.
            //Pass by Reference: The method gets a reference to the original variable.
            //  Changes made inside the method affect the original variable.


            //int x = 10;
            //ValueTypeByValueQ1(x);
            //Console.WriteLine($"Outside Pass By Value: {x}");
            //ValueTypeByRefQ1(ref x);
            //Console.WriteLine($"Outside Pass By Ref: {x}");
            #endregion

            #region Q2
            //By Value:A copy of the reference is passed to the method.
            //     reassigning the reference inside the method does not affect the original reference.
            //By Reference:The actual reference is passed to the method.
            //    The method can modify the object data and can also reassign the reference, affecting the original variable

            //int[] arr = { 1, 2, 3 };
            //RefTypeByValueQ2(arr);
            //Console.WriteLine("Outside Pass By Value: ");
            //PrintQ2(arr);
            //RefTypeByRefQ2(ref arr);
            //Console.WriteLine("Outside Pass By Ref ");
            //PrintQ2(arr);
            #endregion

            #region Q3
            //Console.Write("Enter First Number: ");
            //int x=int.Parse(Console.ReadLine());
            //Console.Write("Enter Second Number: ");
            //int y=int.Parse(Console.ReadLine());
            //SumAndSubQ3(x, y,out int sum,out int sub);
            //Console.WriteLine($"Sum result: {sum}");
            //Console.WriteLine($"Sub result: {sub}");
            #endregion

            #region Q4
            //Console.Write("Enter value to calc sum of digits: ");
            //int x=int.Parse(Console.ReadLine());
            //SumOfDigitsQ4(x);
            #endregion

            #region Q5
            //Console.Write("Enter number to check if prime: ");
            //int x=int.Parse(Console.ReadLine());
            //bool result = IsPrimeQ5(x);
            //if (result)
            //{
            //    Console.WriteLine($"{x} is prime");
            //}
            //else
            //{
            //    Console.WriteLine($"{x} is not prime");
            //}
            #endregion

            #region Q6
            //Console.Write("Enter Array Size: ");
            //int x=int.Parse(Console.ReadLine());
            //int[] arr = new int[x];
            //for (int i = 0; i < x; i++) {
            //    Console.Write($"Enter the {i+1} value: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //MinMaxArrayQ6(ref arr);
            #endregion

            #region Q7
            //Console.Write("Enter Number to get factorial: ");
            //int x = int.Parse(Console.ReadLine());
            //FactorialQ7(x);
            #endregion

            #region Q8
            //Console.Write("Enter the string: ");
            //string x=Console.ReadLine();
            //Console.Write("Enter the index you want to change: ");
            //int index = int.Parse(Console.ReadLine());
            //Console.Write("Enter the new letter: ");
            //char c = char.Parse(Console.ReadLine());
            //ChangeCharQ8(x,index,c);
            #endregion
        }

        public static void ValueTypeByValueQ1(int x)
        {
            x = 15;
            Console.WriteLine($"Inside Pass By Value: {x}");
        }
        public static void ValueTypeByRefQ1(ref int x)
        {
            x = 15;
            Console.WriteLine($"Inside Pass By Ref: {x}");
        }
        public static void RefTypeByValueQ2(int[] arr)
        {
            arr[0] = 5;
            arr = new int[] { 20, 30, 40 };
            Console.WriteLine("Inside Pass By Value: ");
            PrintQ2(arr);
        }
        public static void RefTypeByRefQ2(ref int[] arr)
        {
            arr[0] = 5;
            arr = new int[] { 20, 30, 40 };
            Console.WriteLine("Inside Pass By Ref: ");
            PrintQ2(arr);
        }
        public static void PrintQ2(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++) {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
        }
        public static void SumAndSubQ3(int x,int y,out int sum,out int sub)
        {
            sum = x + y;
            sub = x - y;
        }
        public static void SumOfDigitsQ4(int x)
        {
            double sum = 0;
            double res = x % 10;
            sum=sum+ res;
            x = x / 10;
            res = x % 10;
            sum = sum + res;
            Console.WriteLine($"Sum of digits is {sum}");
        }
        public static bool IsPrimeQ5(int x)
        {
            if (x < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        public static void MinMaxArrayQ6(ref int[] arr)
        {
            Array.Sort(arr);
            Console.Write($"Min: {arr[0]} , ");
            Console.Write($"Max: {arr[arr.Length-1]}");
        }
        public static void FactorialQ7(int x)
        {
            int res = 1;
            for (int i = x; i > 0; i--)
            {
                res=res*i;
            }
            Console.WriteLine($"The factorial of {x} is {res}");
        }
        public static void ChangeCharQ8(string x, int index, char c)
        {
            char[] charArray = x.ToCharArray();
            charArray[index] = c;
            Console.WriteLine($"Changed string: {new string(charArray)}");
        }
    }
}
