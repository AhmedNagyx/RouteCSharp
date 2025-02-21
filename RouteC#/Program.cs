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

            #endregion

            #region Q4

            #endregion

            #region Q5

            #endregion

            #endregion
        }

    }
}
