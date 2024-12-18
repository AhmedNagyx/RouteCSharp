using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine("the number is : " + num);
            #endregion

            #region Q2
            //int x = int.Parse(Console.ReadLine());
            //Console.WriteLine(x);

            //System.FormatException: 'The input string ' as' was not in a correct format.'
            #endregion

            #region Q3
            //float x = float.Parse(Console.ReadLine());
            //float y = float.Parse(Console.ReadLine());
            //float z = x + y;
            //Console.WriteLine(z);

            //calculations involving alot of digits may lose accuracy.
            #endregion

            #region Q4
            //Console.Write("Enter word : ");
            //string input = Console.ReadLine();

            //Console.Write("Enter number of starting letter : ");
            //int starting = int.Parse(Console.ReadLine());
            //starting -= 1;

            //Console.Write("Enter number of letters to count : ");
            //int until = int.Parse(Console.ReadLine());

            //string result = input.Substring(starting, until);
            //Console.WriteLine(result);
            #endregion

            #region Q5
            //int x = 1;
            //int y = x; 
            //y = 2;
            //Console.WriteLine(x);
            //Console.WriteLine(y);

            //each variable in independent as its value type not reference type

            #endregion

            #region Q6
            //int[] arr1 = { 1, 2, 3 };
            //int[] arr2 = arr1;
            //arr2[0] = 4;
            //Console.WriteLine("array 1 : ");
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    Console.WriteLine(arr1[i]);
            //}
            //Console.WriteLine("array 2 : ");
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    Console.WriteLine(arr2[i]);
            //}
            //their values depend on each other as they are reference type point to same address
            #endregion

            #region Q7
            //Console.Write("Enter first name: ");
            //string x = Console.ReadLine();
            //Console.Write("Enter last name: ");
            //string y = Console.ReadLine();
            //string z = $"full name is : {x} {y}";
            //Console.WriteLine(z);
            #endregion

            #region Q8

            //Console.WriteLine("Enter the principal amount:");
            //double principal = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the rate of interest:");
            //double rate = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the time in years:");
            //double time = double.Parse(Console.ReadLine());

            //double interest = (principal * rate * time) / 100;
            //Console.WriteLine($"Interest is: {interest}");
            #endregion

            #region Q9

            //Console.WriteLine("Enter weight in kilograms:");
            //int weight = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter height in meters(ex:1.70):");
            //double height = double.Parse(Console.ReadLine());

            //double bmi = weight / (height * height);
            //Console.WriteLine($"BMI is: {bmi}");

            #endregion

            #region Q10

            //Console.Write("Enter temp: ");
            //int temp = int.Parse(Console.ReadLine());
            //string result = (temp < 10) ? "Just cold" :
            //                (temp > 30) ? "just hot" :
            //                "Just good";
            //Console.WriteLine(result);

            #endregion

            #region Q11

            //Console.Write("Enter day:");
            //int day = int.Parse(Console.ReadLine());
            //Console.Write("Enter month:");
            //int month = int.Parse(Console.ReadLine());
            //Console.Write("Enter year:");
            //int year = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Today’s date: {day} , {month} , {year}");
            //Console.WriteLine($"Today’s date: {day} / {month} / {year}");
            //Console.WriteLine($"Today’s date: {day} - {month} - {year}");
            #endregion

            #region Q12.13.14.15

            //12 c
            //13 f
            //14 d
            //15 d
            #endregion
        }

    }
}
