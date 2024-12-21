using System;
using System.Text;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Q1
            //Console.Write("Enter number: ");
            // bool flag=   int.TryParse(Console.ReadLine(), out int number);
            //if (flag) {
            //    if (number % 3 == 0 && number % 4 == 0)
            //    {
            //        Console.WriteLine("yes");
            //    }
            //    else {
            //        Console.WriteLine("no");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("enter valid number");
            //}
            #endregion

            #region Q2
            //Console.Write("Enter number: ");
            //bool flag = int.TryParse(Console.ReadLine(), out int number);
            //if (flag)
            //{
            //    if (number <0 )
            //        Console.WriteLine("negative");

            //    else if (number > 0) 
            //        Console.WriteLine("positive");

            //    else
            //        Console.WriteLine("zero");
            //}
            //else 
            //    Console.WriteLine("enter valid number");

            #endregion

            #region Q3
            //Console.WriteLine("Enter 3 numbers: ");
            //int[] arr =new int[3];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //Array.Sort(arr);
            //Console.WriteLine($"max is : {arr[2]}");
            //Console.WriteLine($"min is : {arr[0]}");

            #endregion

            #region Q4
            //Console.Write("Enter number: ");
            //bool flag = int.TryParse(Console.ReadLine(), out int number);
            //if (flag)
            //{
            //    if (number % 2 == 0)
            //        Console.WriteLine("even");

            //    else
            //        Console.WriteLine("odd");
            //}
            //else
            //    Console.WriteLine("enter valid number");
            #endregion

            #region Q5
            //Console.WriteLine("Enter letter: ");
            //bool flag= char.TryParse(Console.ReadLine(),out char c);
            //if (flag) { 
            //    if (c == 'a' || c == 'e'|| c == 'o' || c == 'l' || c == 'u')
            //    {
            //        Console.WriteLine("Vowel");
            //    }
            //    else
            //        Console.WriteLine("Not Vowel");
            //}
            //else
            //    Console.WriteLine("Enter a correct letter");
            #endregion

            #region Q6
            //Console.WriteLine("Enter number: ");
            //bool flag= int.TryParse(Console.ReadLine(),out int num);
            //if (flag) {
            //    int sum=0;
            //    for (int i = 1; i <= num; i++)
            //    {
            //        sum += i;                
            //    }
            //    Console.WriteLine(sum);
            //}
            //else
            //    Console.WriteLine("Enter Valid Number");
            #endregion

            #region Q7
            //Console.Write("Enter number to get multiplications: ");
            //bool flag = int.TryParse(Console.ReadLine(), out int num);
            //if (flag)
            //{
            //    Console.Write("Multiplications are: ");
            //   for (int i = 1; i <= 12; i++)
            //    {
            //        Console.Write(i*num+" ");
            //    } 
            //}
            //else
            //    Console.WriteLine("Enter Valid Number");
            #endregion

            #region Q8
            //Console.Write("Enter number to get evens between: ");
            //bool flag = int.TryParse(Console.ReadLine(), out int num);
            //if (flag)
            //{
            //    Console.Write("Evens between are: ");
            //    for (int i = 1; i <= num; i++)
            //    {
            //        if (i % 2==0)
            //        {
            //            Console.Write(i+" ");
            //        }
            //    }
            //}
            //else
            //    Console.WriteLine("Enter Valid Number");
            #endregion

            #region Q9
            //Console.Write("Enter base number: ");
            //bool flag1 = int.TryParse(Console.ReadLine(), out int num1);
            //Console.Write("Enter power number: ");
            //bool flag2 = int.TryParse(Console.ReadLine(), out int num2);
            //if (flag1 && flag2)
            //{
            //    int power = 1;
            //    for (int i = 1; i <= num2; i++)
            //    {
            //        power *= num1;

            //    }
            //    Console.WriteLine(power);
            //}
            //else
            //    Console.WriteLine("Enter Valid Numbers");
            #endregion

            #region Q10
            //int[] arr = new int [5];
            //int grade=0;
            //double avg;
            //double perc;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine($"Enter grade for {i+1} subject: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //    grade += arr[i];
            //}
            //avg = (double)grade / 5;
            //perc = ((double)grade / 500)*100;
            //Console.WriteLine($"Total grades: {grade}, average grade: {avg}, percentage: {perc}%");
            #endregion

            #region Q11
            //Console.Write("Enter month number: ");
            //bool flag1 = int.TryParse(Console.ReadLine(), out int num1);

            //if (flag1 && (num1<13 && num1>0))
            //{
            //    switch (num1) 
            //    {
            //        case 1:
            //            Console.WriteLine(31);
            //            break;
            //        case 2:
            //            Console.WriteLine(28);
            //            break;
            //        case 3:
            //            Console.WriteLine(31);
            //            break;
            //        case 4:
            //            Console.WriteLine(30);
            //            break;
            //        case 5:
            //            Console.WriteLine(31);
            //            break;
            //        case 6:
            //            Console.WriteLine(30);
            //            break;
            //        case 7:
            //            Console.WriteLine(31);
            //            break;
            //        case 8:
            //            Console.WriteLine(31);
            //            break;
            //        case 9:
            //            Console.WriteLine(31);
            //            break;
            //        case 10:
            //            Console.WriteLine(31);
            //            break;
            //        case 11:
            //            Console.WriteLine(30);
            //            break;
            //        case 12:
            //            Console.WriteLine(31);
            //            break;
            //    }

            //}
            //else
            //    Console.WriteLine("Enter valid month number");
            #endregion

            #region Q12
            //Console.Write("Enter first number: ");
            //bool flag1 = double.TryParse(Console.ReadLine(), out double num1);
            //Console.Write("Enter sign to calculate: ");
            //bool flag = char.TryParse(Console.ReadLine(), out char c);
            //Console.Write("Enter second number: ");
            //bool flag2 = double.TryParse(Console.ReadLine(), out double num2);
            //double operation;
            //if (flag1 && flag2 && flag && (c=='+' || c == '*' || c == '-' || c == '/'))
            //{
            //    if(c == '+')
            //    {
            //        operation= num1 + num2;
            //        Console.WriteLine(operation);
            //    }
            //    else if (c == '*')
            //    {
            //        operation = num1 * num2;
            //        Console.WriteLine(operation);
            //    }
            //    else if (c == '-')
            //    {
            //        operation = num1 - num2;
            //        Console.WriteLine(operation);
            //    }
            //    else if (c == '/')
            //    {
            //        operation = num1 / num2;
            //        Console.WriteLine(operation);
            //    }

            //}
            //else
            //    Console.WriteLine("Enter valid numbers");
            #endregion

            #region Q13
            //Console.Write("Enter String: ");
            //StringBuilder s = new StringBuilder(Console.ReadLine());
            //StringBuilder reversed = new StringBuilder(s.Length);
            //for (int i = s.Length -1 ; i >= 0; i--)
            //{
            //    reversed.Append(s[i]);
            //}
            //Console.WriteLine("Reversed string: " + reversed);
            #endregion

            #region Q14
            //Console.Write("Enter number: ");
            //bool flag1 = int.TryParse(Console.ReadLine(), out int num); //269
            //int reverse = 0;
            //while (flag1 && num != 0) {
            //    int digit = num % 10; //9 6 2
            //    reverse= reverse*10 + digit; //9 96 962
            //    num = num / 10; //2
            //}
            //Console.WriteLine($"Reversed number: {reverse}");
            #endregion

            #region Q15 Q16 Q17 IDK

            #endregion

            #region Q18
            //Console.Write("Enter task taken time: ");
            //bool flag1 = double.TryParse(Console.ReadLine(), out double num);
            //if (flag1)
            //{
            //    if (num >=2 && num<3)
            //        Console.WriteLine("highly efficient");
            //    else if (num >= 3 && num < 4)
            //        Console.WriteLine("increase your speed");
            //    else if (num >= 4 && num < 5)
            //        Console.WriteLine("will be provided by training");
            //    else if (num >= 5)
            //        Console.WriteLine("leave the company");
            //}
            //else
            //    Console.WriteLine("Enter valid numbers");
            #endregion

            #region Q19
            //Console.Write("Enter number: ");
            //bool flag1 = int.TryParse(Console.ReadLine(), out int num);
            //if (flag1) { 
            //    for (int i = 0; i < num; i++)
            //    {
            //        for (int j = 0; j < num; j++)
            //        {
            //            if (i == j)
            //            {
            //                Console.Write(1+" ");
            //            }
            //            else
            //                Console.Write(0+" ");
            //        }
            //        Console.WriteLine();
            //    }
            //}
            //else
            //    Console.WriteLine("Enter valid number");
            #endregion

            #region Q20

            //Console.Write("Enter array length: ");
            //bool flag1 = int.TryParse(Console.ReadLine(), out int length);
            //int[] arr = new int[length];
            //int sum = 0;
            //if (flag1) { 
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        Console.Write($"Enter {i+1} value: ");
            //        arr[i] = int.Parse(Console.ReadLine());
            //        sum += arr[i];
            //    }
            //    Console.WriteLine($"Sum of values = {sum}");
            //}
            //else
            //    Console.WriteLine("Enter valid number");
            #endregion

            #region Q21
            //int[] arr1 =  {1,3,5};
            //int[] arr2 =  {2,4,6};
            //int[] arr3 = new int[arr1.Length+arr2.Length];

            //arr1.CopyTo(arr3, 0);
            //arr2.CopyTo(arr3, arr1.Length);

            //Array.Sort(arr3);

            //foreach (int i in arr3)
            //{
            //    Console.Write(i+" ");
            //}
            #endregion

            #region Q22 IDK

            #endregion

            #region Q23 & Q24
            //int[] arr1 = { 8, 9, 3, 4, 1 };

            //Array.Sort(arr1);
            //Console.WriteLine($"min: {arr1[0]}");
            //Console.WriteLine($"max: {arr1[arr1.Length - 1]}");
            //Console.WriteLine($"second max: {arr1[arr1.Length - 2]}");
            #endregion

            #region Q25
            //Console.Write("Enter array size: ");
            //bool flag1 = int.TryParse(Console.ReadLine(), out int length);
            //int[] arr = new int[length];
            //if (flag1)
            //{
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        Console.WriteLine($"Enter the {i+1} value: ");
            //        arr[i] = int.Parse(Console.ReadLine());
            //    }

            //    int dist = 0;

            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        for (int j = 1; j < arr.Length; j++)
            //        {
            //            if (arr[i] == arr[j])//1 2 3 1
            //            {
            //                int distance = j - i -1;
            //                if (distance > dist)
            //                {
            //                    dist = distance;
            //                }
            //            }
            //        }
            //    }
            //    Console.WriteLine("The longest distance is: " + dist);
            //}
            //else
            //    Console.WriteLine("enter valid number");
            #endregion

            #region Q26
            //Console.WriteLine("Enter String: ");
            //string s = Console.ReadLine();
            //string[] StringArr = s.Split(' ');
            //Array.Reverse(StringArr);
            //string reversedWords = string.Join(" ", StringArr);
            //Console.WriteLine(reversedWords);

            #endregion

            #region Q27
            //Console.Write("Enter array rows: ");
            //bool flag1=int.TryParse(Console.ReadLine(), out int rows);
            //Console.Write("Enter array columns: ");
            //bool flag2 = int.TryParse(Console.ReadLine(), out int columns);
            //if (flag1 && flag2)
            //{
            //    int[,] arr1 = new int[rows,columns];
            //    int[,] arr2 = new int[rows, columns];
            //    for (int i = 0; i < rows; i++)
            //    {
            //        for (int j = 0; j < columns; j++)
            //        {
            //            Console.Write($"Enter row {i+1} and column {j+1} value: ");
            //            arr1[i, j] = int.Parse(Console.ReadLine());
            //        }
            //    }
            //    Array.Copy(arr1, arr2, arr1.Length);

            //    Console.WriteLine("second array after copying:");
            //    for (int i = 0; i < rows; i++)
            //    {
            //        for (int j = 0; j < columns; j++)
            //        {
            //            Console.Write(arr2[i, j] + " ");
            //        }
            //        Console.WriteLine();
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("enter valid size");
            //}
            #endregion

            #region Q28
            //Console.Write("Enter array size: ");
            //bool flag1 = int.TryParse(Console.ReadLine(), out int num);
            //if (flag1)
            //{
            //    int[] arr = new int[num];

            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        Console.Write($"Enter value {i+1}: ");
            //        arr[i] = int.Parse(Console.ReadLine());
            //    }
            //    Array.Reverse(arr);
            //    Console.Write("Array in reverse order:");
            //    foreach (int x in arr)
            //    {
            //        Console.Write(x + " ");
            //    }
            //}
            //else
            //    Console.WriteLine("enter valid number");
            #endregion
        }

    }
}
    