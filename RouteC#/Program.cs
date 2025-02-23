using System;
using static LinqDemo.ListGenerator;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Partitioning Operators

            #region Q1
            //var result = CustomerList.Where(customer => customer.City == "Washington") //no orders in washington
            //    .SelectMany(order => order.Orders)
            //    .OrderBy(order => order.OrderDate)
            //    .Take(3);

            //if (result.Count() > 0)
            //{
            //    foreach (var item in result)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            //else Console.WriteLine("No order found");
            #endregion

            #region Q2
            //var result = CustomerList.Where(customer => customer.City == "London") //no orders in washington
            //    .SelectMany(order => order.Orders)
            //    .OrderBy(order => order.OrderDate)
            //    .Skip(2);

            //if (result.Count() > 0)
            //{
            //    foreach (var item in result)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            //else Console.WriteLine("No order found");
            #endregion

            #region Q3

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers
            //    .Select((num, index) => new { num, index })
            //    .TakeWhile(value => value.num >= value.index)
            //    .Select(value => value.num);

            //foreach (var num in result)
            //{
            //    Console.WriteLine(num);
            //}
            #endregion

            #region Q4
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.SkipWhile(num => num % 3 != 0);

            //foreach (var num in result)
            //{
            //    Console.WriteLine(num);
            //}
            #endregion

            #region Q5
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers
            //    .Select((num, index) => new { num, index })
            //    .SkipWhile(x => x.num >= x.index)
            //    .Select(x => x.num);

            //foreach (var num in result)
            //{
            //    Console.WriteLine(num);
            //}
            #endregion

            #endregion

            #region Grouping Operators

            #region Q1
            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var result = numbers.GroupBy(num => num % 5);

            //foreach (var group in result)
            //{
            //    Console.WriteLine($"Remainder {group.Key}");
            //    foreach (var item in group)
            //    {
            //        Console.WriteLine(item);
            //    }

            //}
            #endregion

            #region Q2
            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var result = words.GroupBy(word => char.ToLower(word[0])).OrderBy(group=>group.Key);

            //foreach (var group in result)
            //{
            //    Console.WriteLine("=================================================================");
            //    Console.WriteLine("=================================================================");
            //    Console.WriteLine("=================================================================");

            //    Console.WriteLine($"Charater: {group.Key}");
            //    foreach (var item in group)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            #endregion

            #region Q3
            //string[] Arr = { "from", "salt", "earn", " last", "near", "form" };

            //var result = Arr.Select(word => word.Trim()).GroupBy(word => word, new MyComparer());

            //foreach (var group in result)
            //{
            //    Console.WriteLine(string.Join(", ", group));
            //    Console.WriteLine("========");
            //}
            #endregion

            #endregion
        }
         
    }

    class MyComparer : IEqualityComparer<string>
    {
        public bool Equals(string x, string y)
        {
            if (x == null || y == null)
                return false;
            else
            {
                return new string(x.OrderBy(c => c).ToArray()) == new string(y.OrderBy(c => c).ToArray());
            }
        }

        public int GetHashCode(string obj)
        {
            return 0;
        }
    }
}
