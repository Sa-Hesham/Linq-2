using LINQ_1;
using System.Collections.Generic;
using System.Threading;
using System.Xml;
using static LINQ_1.ListGenerator;

namespace Linq_2
 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Element Operators
            //1.Get first Product out of Stock

            //var FirstProduct = Products.FirstOrDefault(x=>x.UnitsInStock==0)
            //    ?? new Product() {ProductID = 0 ,ProductName = "no name" ,Category="no name" ,UnitPrice =0 ,UnitsInStock=0 };
            // Console.WriteLine(FirstProduct);


            //2.Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            //var firstProductPrice = Products.FirstOrDefault(x => x.UnitPrice > 1000) ;
            //Console.WriteLine(firstProductPrice);


            //3.Retrieve the second number greater than 5

            // int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //Array.Sort(Arr);

            //int result = Arr.Where(Number => Number > 5).ElementAtOrDefault(^2);

            //Console.WriteLine(result);


            //var result02=Arr.Where(x=>x>5).Skip(1).FirstOrDefault();
            //Console.WriteLine(result02);


            #endregion





            #region Aggregate Operators

            // 1.Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.LongCount(x => x % 2 != 0);
            //Console.WriteLine(result);


            //2.Return a list of customers and how many orders each has.

            //var CustomersOders = Customers.Select(x => new
            //{
            //    Name = x.CustomerName,
            //    OrdersNumber = x.Orders?.Length ?? 0,
            //});

            //foreach (var c in CustomersOders)
            //{

            //    Console.WriteLine($"{c.Name} =>>> {c.OrdersNumber}");

            //}


            //3.Return a list of categories and how many products each has


            //var CategoryCout = Products
            //    .GroupBy(x => x.Category)
            //    .Select(m => new
            //{
            //    categoryName = m.Key,
            //    count = m.Count()
            //}).ToList();


            //foreach (var category in CategoryCout) {

            //    Console.WriteLine(category);

            //}


            //4. Get the total of the numbers in an array.

            // int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var sum = Arr.Sum();
            //Console.WriteLine(sum);

            //var sum = Arr.Aggregate((x, y) => x + y);
            //Console.WriteLine(sum);



            //string path = "dictionary_english.txt";

            //string[] words = File.ReadAllLines(path);

            //5.Get the total number of characters of all words in 

            //var numberOfchar = words.Sum(x => x.Length);
            //   Console.WriteLine(numberOfchar);



            //6. Get the length of the shortest word in

            //var shorestWord = words.MinBy(x => x.Length);
            //Console.WriteLine(shorestWord);



            // 7.Get the length of the longest word in dictionary_english.txt

            //var longestWord = words.MaxBy(w => w.Length);
            //Console.WriteLine(longestWord);


            //8.Get the average length of the words in 

            //var avrage = words.Average( words =>words.Length);
            //Console.WriteLine((int)avrage);


            // 9.Get the total units in stock for each product category.


            //var Totoalunit = Products.GroupBy(x => x.Category)
            //    .Select(a => new
            //    {
            //        category = a.Key,
            //        units =a.Sum(x=>x.UnitsInStock)
            //    }).ToList();

            //foreach (var item in Totoalunit) {

            //    Console.WriteLine(item);

            //}



            //10.Get the cheapest price among each category's products

            //var price = Products.GroupBy(x => x.Category)
            //    .Select(a => new
            //    {
            //        categoryname= a.Key,
            //        cheapesprice= a.Min(x=>x.UnitPrice)


            //    });


            // 11.Get the products with the cheapest price in each category(Use Let)

            //var cheapestProducts =
            //   from p in Products
            // group p by p.Category into g                  
            //    let cheapest = g.OrderBy(x => x.UnitPrice)    
            //        .First()                   
            //select cheapest;

            //foreach (var product in cheapestProducts)
            //{
            //    Console.WriteLine($" {product.Category}  {product.ProductName}  {product.UnitPrice}");
            //}



            // 12.Get the most expensive price among each category's products.

            //var mostExpensivePerCategory =
            //from p in Products
            //group p by p.Category into g
            //select new
            //{
            //    Category = g.Key,
            //    MaxPrice = g.Max(p => p.UnitPrice)
            //};

            //foreach (var item in mostExpensivePerCategory)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Most Price: {item.MaxPrice}");
            //}


            // 13.Get the products with the most expensive price in each category.
            // var mostExpensiveProducts = Products
            //.GroupBy(p => p.Category)                 
            //.Select(g => g.OrderByDescending(p => p.UnitPrice)  
            //                .First());                

            //foreach (var product in mostExpensiveProducts)
            //{
            //    Console.WriteLine($"Category: {product.Category}, Product: {product.ProductName}, Price: {product.UnitPrice:C}");
            //}


            #endregion


            #region Aggregate Operators

            // 1.Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.LongCount(x => x % 2 != 0);
            //Console.WriteLine(result);


            //2.Return a list of customers and how many orders each has.

            //var CustomersOders = CustomerList.Select(x => new
            //{
            //    Name = x.CustomerName,
            //    OrdersNumber = x.Orders?.Length ?? 0,
            //});

            //foreach (var c in CustomersOders)
            //{

            //    Console.WriteLine($"{c.Name} =>>> {c.OrdersNumber}");

            //}


            //3.Return a list of categories and how many products each has


            //var CategoryCout = Products
            //    .GroupBy(x => x.Category)
            //    .Select(m => new
            //{
            //    categoryName = m.Key,
            //    count = m.Count()
            //}).ToList();


            //foreach (var category in CategoryCout) {

            //    Console.WriteLine(category);

            //}


            //4. Get the total of the numbers in an array.

            // int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var sum = Arr.Sum();
            //Console.WriteLine(sum);

            //var sum = Arr.Aggregate((x, y) => x + y);
            //Console.WriteLine(sum);



            //string path = "dictionary_english.txt";

            //string[] words = File.ReadAllLines(path);

            //5.Get the total number of characters of all words in 

            //var numberOfchar = words.Sum(x => x.Length);
            //   Console.WriteLine(numberOfchar);



            //6. Get the length of the shortest word in

            //var shorestWord = words.MinBy(x => x.Length);
            //Console.WriteLine(shorestWord);



            // 7.Get the length of the longest word in dictionary_english.txt

            //var longestWord = words.MaxBy(w => w.Length);
            //Console.WriteLine(longestWord);


            //8.Get the average length of the words in 

            //var avrage = words.Average( words =>words.Length);
            //Console.WriteLine((int)avrage);


            // 9.Get the total units in stock for each product category.


            //var Totoalunit = Products.GroupBy(x => x.Category)
            //    .Select(a => new
            //    {
            //        category = a.Key,
            //        units =a.Sum(x=>x.UnitsInStock)
            //    }).ToList();

            //foreach (var item in Totoalunit) {

            //    Console.WriteLine(item);

            //}



            //10.Get the cheapest price among each category's products

            //var price = Products.GroupBy(x => x.Category)
            //    .Select(a => new
            //    {
            //        categoryname= a.Key,
            //        cheapesprice= a.Min(x=>x.UnitPrice)


            //    });


            // 11.Get the products with the cheapest price in each category(Use Let)

            //var cheapestProducts =
            //   from p in Products
            // group p by p.Category into g                  
            //    let cheapest = g.OrderBy(x => x.UnitPrice)    
            //        .First()                   
            //select cheapest;

            //foreach (var product in cheapestProducts)
            //{
            //    Console.WriteLine($" {product.Category}  {product.ProductName}  {product.UnitPrice}");
            //}



            // 12.Get the most expensive price among each category's products.

            //var mostExpensivePerCategory =
            //from p in Products
            //group p by p.Category into g
            //select new
            //{
            //    Category = g.Key,
            //    MaxPrice = g.Max(p => p.UnitPrice)
            //};

            //foreach (var item in mostExpensivePerCategory)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Most Price: {item.MaxPrice}");
            //}


            // 13.Get the products with the most expensive price in each category.
            // var mostExpensiveProducts = Products
            //.GroupBy(p => p.Category)                 
            //.Select(g => g.OrderByDescending(p => p.UnitPrice)  
            //                .First());                

            //foreach (var product in mostExpensiveProducts)
            //{
            //    Console.WriteLine($"Category: {product.Category}, Product: {product.ProductName}, Price: {product.UnitPrice:C}");
            //}


            #endregion




            #region  Set Operators
            // Find the unique Category names from Product List
            //var uniqueCategories = Products
            //    .Select(p => p.Category)
            //    .Distinct();               

            //foreach (var category in uniqueCategories)
            //{
            //    Console.WriteLine(category);
            //}


            //2. Produce a Sequence containing the unique first letter from both product and customer names.
            //var produce= Products.Select(x => x.ProductName[0]).Concat(CustomerList.Select(m => m.CustomerName[0])).Distinct();
            //foreach (var item in produce) {

            //    Console.WriteLine(item);

            //}


            //3.Create one sequence that contains the common first letter from both product and customer names.

            //var sequance = Products.Select(x => x.ProductName[0]).Intersect(CustomerList.Select(x => x.CustomerName[0]));
            //foreach (var item in sequance) {
            //    Console.WriteLine(item);

            //}


            //4.Create one sequence that contains the first letters of product names that are not also first letters of customer names.

            //var seq= Products.Select(x => x.ProductName[0]).Except(CustomerList.Select(c=>c.CustomerName[0]));
            //foreach (var item in seq) {
            //    Console.WriteLine(item);

            //}

            //5.Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
            //var sequ = Products
            //    .Where(x => x.ProductName.Length >= 3) 
            //    .Select(x => x.ProductName.Substring(x.ProductName.Length - 3)) 
            //    .Concat(
            //        CustomerList
            //            .Where(c => c.CustomerName.Length >= 3)
            //            .Select(c => c.CustomerName.Substring(c.CustomerName.Length - 3))
            //    );

            //foreach (var s in sequ)
            //{
            //    Console.WriteLine(s);
            //}



            #endregion
        }
    }
}
