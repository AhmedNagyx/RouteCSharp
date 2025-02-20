using System;
using static ASSLINQ.ListGenerators;
namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Element Operators

            #region Q1
            //var result = ProductList.FirstOrDefault(item => item.UnitsInStock == 0);
            //Console.WriteLine(result != null? result : " No product found.");
            #endregion

            #region Q2
            //var result = ProductList.FirstOrDefault(item => item.UnitPrice > 1000);
            //Console.WriteLine(result != null ? result : "No product found.");
            #endregion

            #region Q3
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            //var result= Arr.Where(value=> value>5).Skip(1).FirstOrDefault();

            //Console.WriteLine(result !=null ? result : "No second number grater than 5");
            #endregion

            #endregion

            #region Aggregate Operators

            #region Q1
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var item = Arr.Where(value=> value % 2 == 1).Count();

            //Console.WriteLine(item);
            #endregion

            #region Q2
            //var result = CustomerList.Select(value => new
            //{
            //    Customer = value.CustomerName,
            //    Orders = value.Orders.Count()
            //});

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q3
            //var result = ProductList.GroupBy(value => value.Category).Select(value =>new 
            //{
            //   Category=value.Key,
            //   Products=value.Count()
            //});

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var sum = Arr.Sum();

            //Console.WriteLine(sum);
            #endregion

            #region Q5
            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //int result = words.Sum(word => word.Length);

            //Console.WriteLine(result);
            #endregion

            #region Q6 Q7 Q8
            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var result1= words.Min(word => word.Length);
            //var result2 = words.Max(word => word.Length);
            //var result3 = words.Average(word => word.Length);

            //Console.WriteLine($"Shortest: {result1} \n Longest: {result2} \n Average: {result3}");

            #endregion

            #region Q9
            //var result = ProductList.GroupBy(value => value.Category).Select(value => new
            //{
            //    Category = value.Key,
            //    UnitsInStock = value.Sum(item => item.UnitsInStock)
            //});

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q10
            //var result = ProductList.GroupBy(value => value.Category).Select(value => new
            //{
            //    Category = value.Key,
            //    CheapestPrice = value.Min(value=> value.UnitPrice)
            //});

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q11
            //var result= from product in ProductList
            //            group product by product.Category into grouped
            //            let cheapest= grouped.Min(value=> value.UnitPrice)
            //            from item in grouped
            //            where item.UnitPrice== cheapest
            //            select new
            //            {
            //                Category = item.Category,
            //                Product= item.ProductName,
            //                UnitPrice = item.UnitPrice
            //            };
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q12
            //var result = ProductList.GroupBy(value => value.Category).Select(value => new
            //{
            //    Category = value.Key,
            //    MostExpensivePrice = value.Max(value => value.UnitPrice)
            //});

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q13
            //var result = ProductList.GroupBy(value => value.Category).Select(group => new
            //{
            //    Category=group.Key,
            //    Product=group.Where(item => item.UnitPrice == group.Max(item2 => item2.UnitPrice)),
            //    Price=group.Max(item => item.UnitPrice)
            //});

            //foreach (var group in result)
            //{
            //    foreach (var item in group.Product)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            #endregion

            #region Q14
            //var result = ProductList.GroupBy(value => value.Category).Select(group => new
            //{
            //    Category = group.Key,
            //    AveragePrice = group.Average(item => item.UnitPrice)
            //});

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #endregion

            #region Set Operators
            #region Q1
            //var result = ProductList.Select(value => value.Category).Distinct();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q2
            //var result = ProductList.Select(item => item.ProductName[0]).Union(CustomerList.Select(item => item.CustomerName[0])).Distinct();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q3
            //var result = ProductList.Select(item=> item.ProductName[0]).Intersect(CustomerList.Select(item=>item.CustomerName[0]));

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q4
            //var result = ProductList.Select(item => item.ProductName[0]).Except(CustomerList.Select(item => item.CustomerName[0]));

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q5

            #endregion
            //var result = ProductList.Select(item => item.ProductName.Length > 3 ? item.ProductName[^3..] : item.ProductName)
            //            .Union(CustomerList.Select(item => item.CustomerName.Length > 3 ? item.CustomerName[^3..] : item.CustomerName));

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Quantifiers

            #region Q1
            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var result = words.Any(word=>word.Contains("ei"));
            //Console.WriteLine(result);
            #endregion


            #region Q2
            //var result = ProductList.GroupBy(category => category.Category).Where(item => item.Any(product => product.UnitsInStock == 0)).
            //    Select(group => new
            //    {
            //        Category = group.Key,
            //        Products = group.ToList()
            //    });
            //foreach (var category in result)
            //{
            //    Console.WriteLine(category.Category);
            //    foreach (var product in category.Products)
            //    {
            //        Console.WriteLine(product);
            //    }
            //    Console.WriteLine("=======================");
            //}
            #endregion


            #region Q3
            //var result = ProductList.GroupBy(category => category.Category).Where(item => item.Any(product => product.UnitsInStock != 0)).
            //    Select(group => new
            //    {
            //        Category = group.Key,
            //        Products = group.ToList()
            //    });
            //foreach (var category in result)
            //{
            //    Console.WriteLine(category.Category);
            //    foreach (var product in category.Products)
            //    {
            //        Console.WriteLine(product);
            //    }
            //    Console.WriteLine("=======================");
            //}
            #endregion

            #endregion

        }

    }
}
