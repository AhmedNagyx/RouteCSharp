using System;
using Microsoft.EntityFrameworkCore;
using RouteC_.Models;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                //NorthwindContextProcedures procedures  = new NorthwindContextProcedures(context);
                //var product = procedures.SalesByCategoryAsync("Beverages","1998").Result;
                //foreach (var item in product)
                //{
                //    Console.WriteLine($"{item.ProductName} <> {item.TotalPurchase}");
                //}




                //var result = context.Categories.FromSqlRaw("select * from Categories").ToList();
                //foreach (var category in result)
                //{
                //    Console.WriteLine($"{category.CategoryName} <> {category.CategoryID}");
                //}



                //var category = "Beverages";
                //var result = context.Categories.FromSqlInterpolated($"select * from Categories where CategoryName = {category}").ToList();
                //foreach (var item in result)
                //{
                //    Console.WriteLine($"{item.CategoryName} <> {item.Description}");
                //}


            }
        }

    }
}
