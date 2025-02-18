using RouteC_;
using System;
using System.Runtime.Intrinsics.Arm;
using System.Threading;
using static RouteC_.ListGenerator;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Restriction Operators

            #region 1
            //var OutOfStock = ProductList.Where(product => product.UnitsInStock == 0);

            //var OutOfStock = from Product in ProductList
            //                 where Product.UnitsInStock == 0
            //                 select Product;

            //foreach (var Product in OutOfStock)
            //{
            //    Console.WriteLine(Product);
            //}
            #endregion

            #region 2
            //var result = ProductList.Where(product => product.UnitsInStock > 0 && product.UnitPrice>3m);

            //var result = from product in ProductList
            //             where product.UnitsInStock>0 && product.UnitPrice>3m
            //             select product;

            //foreach (var Product in result)
            //{
            //    Console.WriteLine(Product);
            //}
            #endregion

            #region 3
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result= Arr.Select((name,index) => new {Name = name , Value = index}).
            //    Where(x => x.Name.Length < x.Value ).
            //    Select(x=> x.Value).ToArray();

            //Console.WriteLine(string.Join(",",result));
            #endregion

            #endregion

            #region Ordering Operators

            #region 1
            //var result = ProductList.OrderBy(product => product.ProductName);

            //var result = from Product in ProductList
            //             orderby Product.ProductName
            //             select Product;

            //foreach (var Product in result)
            //{
            //    Console.WriteLine(Product);
            //}
            #endregion

            #region 2
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var sorted = Arr.OrderBy(value => value, new CaseInsensitiveComparer()).ToArray();

            //foreach (var str in sorted)
            //{
            //    Console.WriteLine(string.Join(",",str));
            //}
            #endregion

            #region 3
            //var result = ProductList.OrderByDescending(Product => Product.UnitsInStock);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 4
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            //var result = Arr.OrderBy(item => item.Length).ThenBy(item => item);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 5
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result= Arr.OrderBy(item => item.Length).ThenBy(item => item , new CaseInsensitiveComparer()).ToArray();
            //foreach (var str in result)
            //{
            //    Console.WriteLine(string.Join(",", str));
            //}

            #endregion

            #region 6
            //var result = ProductList.OrderBy(item => item.Category).ThenByDescending(item => item.UnitPrice);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 7
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result= Arr.OrderBy(item => item.Length).ThenByDescending(item => item, new CaseInsensitiveComparer()).ToArray();
            //foreach (var str in result)
            //{
            //    Console.WriteLine(string.Join(",", str));
            //}
            #endregion

            #region 8
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr.Where(item => item[1] == 'i').Reverse();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion

            #region Transformation Operators
            #region 1
            //var result = ProductList.Select(item => item.ProductName);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 2
            //String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var result = words.Select(item => new {Word=item, Upper=item.ToUpper(), Lower=item.ToLower()});

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 3
            //var result = ProductList.Select(item=> new { item.ProductName, item.ProductID, Price = item.UnitPrice });

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result= Arr.Select((value,index)=> new {value,index}).Where(item => item.value==item.index);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 5
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var result=numbersA.SelectMany(a=>numbersB,(a,b)=>new {a,b}).Where(value => value.a < value.b);

            //foreach (var value in result)
            //{
            //    Console.WriteLine(value);
            //}
            #endregion

            #region 6
            //var result = CustomerList.SelectMany(cust => cust.Orders).Where(ord => ord.Total < 500);

            //foreach (var order in result)
            //{
            //    Console.WriteLine(order);
            //}
            #endregion

            #region 7
            //var result = CustomerList.SelectMany(ord => ord.Orders).Where(ord => ord.OrderDate.Year >= 1998);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion
        }

    }
}
