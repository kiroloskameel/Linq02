using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        #region Question 1: Get top 3 most expensive products
        {
            // var top3Products = ListGenerator.ProductList
            //     .OrderByDescending(p => p.UnitPrice)
            //     .Take(3);
            // 
            // foreach (var product in top3Products)
            // {
            //     Console.WriteLine($"Name: {product.ProductName}, Price: {product.UnitPrice}");
            // }
        }
        #endregion

        #region Question 2: Show page 2 of products, with page size = 5
        {
            // var page2Products = ListGenerator.ProductList
            //     .Skip(5)
            //     .Take(5);
            // 
            // foreach (var product in page2Products)
            // {
            //     Console.WriteLine(product.ProductName);
            // }
        }
        #endregion

        #region Question 3: Take products as long as UnitPrice < $25 (list ordered by price)
        {
            // var filtered = ListGenerator.ProductList
            //     .OrderBy(p => p.UnitPrice)
            //     .TakeWhile(p => p.UnitPrice < 25);
            // 
            // foreach (var product in filtered)
            // {
            //     Console.WriteLine($"Name: {product.ProductName}, Price: {product.UnitPrice}");
            // }
        }
        #endregion

        #region Question 4: Check if ALL products in the "Seafood" category are in stock
        {
            // bool allInStock = ListGenerator.ProductList
            //     .Where(p => p.Category == "Seafood")
            //     .All(p => p.UnitsInStock > 0);
            // 
            // Console.WriteLine($"Are all Seafood products in stock? {allInStock}");
        }
        #endregion

        #region Question 5: Check if the ID list contains 9
        //{
        //    int[] ids = { 3, 9, 13, 18 };

        //    bool containsNine = ids.Contains(9);
        //    Console.WriteLine($"Contains 9: {containsNine}");
        //}
        #endregion

        #region Question 6: Group all products by Category and print each group with its product count
        {
            // var categoryGroups = ListGenerator.ProductList
            //     .GroupBy(p => p.Category);
            // 
            // foreach (var group in categoryGroups)
            // {
            //     Console.WriteLine($"Category: {group.Key}, Count: {group.Count()}");
            // }
        }
        #endregion

        #region Question 7: Group products by Category and project only product names per group
        {
            // var categoryGroups = ListGenerator.ProductList
            //     .GroupBy(p => p.Category)
            //     .Select(g => new {
            //         Category = g.Key,
            //         ProductNames = g.Select(p => p.ProductName)
            //     });
            // 
            // foreach (var group in categoryGroups)
            // {
            //     Console.WriteLine($"--- Category: {group.Category} ---");
            //     foreach (var name in group.ProductNames)
            //     {
            //         Console.WriteLine($"  {name}");
            //     }
            // }
        }
        #endregion

        #region Question 8: Find all categories that have MORE THAN 3 products
        {
            // var categories = ListGenerator.ProductList
            //     .GroupBy(p => p.Category)
            //     .Where(g => g.Count() > 3)
            //     .Select(g => g.Key);
            // 
            // foreach (var cat in categories)
            // {
            //     Console.WriteLine(cat);
            // }
        }
        #endregion

        #region Question 9: QUERY SYNTAX, group customers by Country, and for each group select { Country, Count, TotalOrderValue }
        {
            // var result = from c in ListGenerator.CustomerList
            //              group c by c.Country into g
            //              select new {
            //                  Country = g.Key,
            //                  Count = g.Count(),
            //                  TotalOrderValue = g.Sum(c => c.Orders.Sum(o => o.Total)) // بناءً على هيكلة الأوبجكت لديك
            //              };
            // 
            // foreach (var item in result)
            // {
            //     Console.WriteLine($"Country: {item.Country}, Count: {item.Count}");
            // }
        }
        #endregion

        #region Question 10: Calculate the total number of units in stock across all products
        {
            // int totalStock = ListGenerator.ProductList
            //     .Sum(p => p.UnitsInStock);
            // 
            // Console.WriteLine($"Total Units in Stock: {totalStock}");
        }
        #endregion

        #region Question 11: Find the CHEAPEST and MOST EXPENSIVE product prices
        {
            // decimal minPrice = ListGenerator.ProductList.Min(p => p.UnitPrice);
            // decimal maxPrice = ListGenerator.ProductList.Max(p => p.UnitPrice);
            // 
            // Console.WriteLine($"Cheapest Price: {minPrice}, Most Expensive Price: {maxPrice}");
        }
        #endregion

        #region Question 12: Get a distinct list of all product categories
        {
            // var categories = ListGenerator.ProductList
            //     .Select(p => p.Category)
            //     .Distinct();
            // 
            // foreach (var cat in categories)
            // {
            //     Console.WriteLine(cat);
            // }
        }
        #endregion

        #region Question 13: Find product IDs that are in setA but NOT in setB
        //{
        //    int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
        //    int[] setB = { 3, 6, 9, 12, 15, 13 };

        //    var result = setA.Except(setB);

        //    foreach (var id in result)
        //    {
        //        Console.WriteLine(id);
        //    }
        //}
        #endregion

        #region Question 14: Find countries that appear in list1 but NOT in list2 (case-insensitive)
        //{
        //    string[] list1 = { "Germany", "France", "UK", "Spain" };
        //    string[] list2 = { "france", "SPAIN", "Italy" };

        //    var result = list1.Except(list2, StringComparer.OrdinalIgnoreCase);

        //    foreach (var country in result)
        //    {
        //        Console.WriteLine(country);
        //    }
        //}
        #endregion

        #region Question 15: Build a Dictionary<int, Product> keyed by ProductID. Then retrieve and print ID=18
        {
            // var productDict = ListGenerator.ProductList
            //     .ToDictionary(p => p.ProductID);
            // 
            // if (productDict.TryGetValue(18, out var product))
            // {
            //     Console.WriteLine($"Found: {product.ProductName}");
            // }
        }
        #endregion

        #region Question 16: Get the first product whose price is greater than $50
        {
            // var product = ListGenerator.ProductList
            //     .First(p => p.UnitPrice > 50);
            // 
            // Console.WriteLine($"Name: {product.ProductName}, Price: {product.UnitPrice}");
        }
        #endregion

        #region Question 17: Try to get the first product with a price > $500 (returns null instead of throwing)
        {
            // var product = ListGenerator.ProductList
            //     .FirstOrDefault(p => p.UnitPrice > 500);
            // 
            // if (product == null)
            // {
            //     Console.WriteLine("No product found with price > $500 (Returned null safely).");
            // }
        }
        #endregion

        #region Question 18: Generate a multiplication table row for 7
        //{
        //    var tableRow = Enumerable.Range(1, 12)
        //        .Select(n => n * 7);

        //    foreach (var val in tableRow)
        //    {
        //        Console.WriteLine(val);
        //    }
        //}
        #endregion

        #region Question 19: Generate even numbers between 1 and 30
        //{
        //    var evenNumbers = Enumerable.Range(1, 30)
        //        .Where(n => n % 2 == 0);

        //    foreach (var num in evenNumbers)
        //    {
        //        Console.WriteLine(num);
        //    }
        //}
        #endregion

        #region Question 20: Concatenate the first 3 product names with the first 3 customer company names
        {
            // var result = ListGenerator.ProductList
            //     .Take(3)
            //     .Select(p => p.ProductName)
            //     .Concat(
            //         ListGenerator.CustomerList.Take(3).Select(c => c.CompanyName)
            //     );
            // 
            // foreach (var item in result)
            // {
            //     Console.WriteLine(item);
            // }
        }
        #endregion

        #region Question 21: Pair each product with a customer (by position) and produce a string "ProductName sold to CompanyName"
        {
            // var zipped = ListGenerator.ProductList
            //     .Zip(ListGenerator.CustomerList, (p, c) => $"{p.ProductName} sold to {c.CompanyName}");
            // 
            // foreach (var item in zipped)
            // {
            //     Console.WriteLine(item);
            // }
        }
        #endregion
    }
}