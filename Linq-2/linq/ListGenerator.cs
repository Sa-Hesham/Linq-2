using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQ_1
{
    internal  static class ListGenerator
    {
      
        internal static List<Customer> CustomerList { get ; set; }
        internal static List<Product> Products { get ; set ; }
       internal static List <Order> orders{ get ; set ; }

        static  ListGenerator()
        {

            Products = new List<Product>()
            {

                        new Product() {ProductID = 1, ProductName = "Chai", Category = "Beverages",
                            UnitPrice = 18.00M, UnitsInStock = 100},
                        new Product{ ProductID = 2, ProductName = "Chang", Category = "Beverages",
                        UnitPrice = 19.0000M, UnitsInStock = 17 },
                      new Product{ ProductID = 3, ProductName = "Aniseed Syrup", Category = "Condiments",
                        UnitPrice = 10.0000M, UnitsInStock = 13 },
                      new Product{ ProductID = 4, ProductName = "Chef Anton's Cajun Seasoning", Category = "Condiments",
                        UnitPrice = 22.0000M, UnitsInStock = 53 },
                      new Product{ ProductID = 5, ProductName = "Chef Anton's Gumbo Mix", Category = "Condiments",
                        UnitPrice = 21.3500M, UnitsInStock = 0 },
                      new Product{ ProductID = 6, ProductName = "Grandma's Boysenberry Spread", Category = "Condiments",
                        UnitPrice = 25.0000M, UnitsInStock = 120 },
                      new Product{ ProductID = 7, ProductName = "Uncle Bob's Organic Dried Pears", Category = "Produce",
                        UnitPrice = 30.0000M, UnitsInStock = 15 },
                      new Product{ ProductID = 8, ProductName = "Northwoods Cranberry Sauce", Category = "Condiments",
                        UnitPrice = 40.0000M, UnitsInStock = 6 },
                      new Product{ ProductID = 9, ProductName = "Mishi Kobe Niku", Category = "Meat/Poultry",
                        UnitPrice = 97.0000M, UnitsInStock = 29 },
                      new Product{ ProductID = 10, ProductName = "Ikura", Category = "Seafood",
                        UnitPrice = 31.0000M, UnitsInStock = 31 },
                      new Product{ ProductID = 11, ProductName = "Queso Cabrales", Category = "Dairy Products",
                        UnitPrice = 21.0000M, UnitsInStock = 22 },
                      new Product{ ProductID = 12, ProductName = "Queso Manchego La Pastora", Category = "Dairy Products",
                        UnitPrice = 38.0000M, UnitsInStock = 86 },
                      new Product() { ProductID = 13, ProductName = "Konbu", Category = "Seafood",
                        UnitPrice = 6.0000M, UnitsInStock = 24 },
                      new Product() { ProductID = 14, ProductName = "Tofu", Category = "Produce",
                        UnitPrice = 23.2500M, UnitsInStock = 35 },
                      new Product() { ProductID = 15, ProductName = "Genen Shouyu", Category = "Condiments",
                        UnitPrice = 15.5000M, UnitsInStock = 39 },
                      new Product() { ProductID = 16, ProductName = "Pavlova", Category = "Confections",
                        UnitPrice = 17.4500M, UnitsInStock = 29 },
                      new Product() { ProductID = 17, ProductName = "Alice Mutton", Category = "Meat/Poultry",
                        UnitPrice = 39.0000M, UnitsInStock = 0 },
                      new Product() { ProductID = 18, ProductName = "Carnarvon Tigers", Category = "Seafood",
                        UnitPrice = 62.5000M, UnitsInStock = 42 },
                      new Product() { ProductID = 19, ProductName = "Teatime Chocolate Biscuits", Category = "Confections",
                        UnitPrice = 9.2000M, UnitsInStock = 25 },
                      new Product() { ProductID = 20, ProductName = "Sir Rodney's Marmalade", Category = "Confections",
                        UnitPrice = 81.0000M, UnitsInStock = 40 },
                      new Product() { ProductID = 21, ProductName = "Sir Rodney's Scones", Category = "Confections",
                        UnitPrice = 10.0000M, UnitsInStock = 3 },
                      new Product() { ProductID = 22, ProductName = "Gustaf's Knäckebröd", Category = "Grains/Cereals",
                        UnitPrice = 21.0000M, UnitsInStock = 104 },
                      new Product() { ProductID = 23, ProductName = "Tunnbröd", Category = "Grains/Cereals",
                        UnitPrice = 9.0000M, UnitsInStock = 61 },
                      new Product() { ProductID = 24, ProductName = "Guaraná Fantástica", Category = "Beverages",
                        UnitPrice = 4.5000M, UnitsInStock = 20 },
                      new Product() { ProductID = 25, ProductName = "NuNuCa Nuß-Nougat-Creme", Category = "Confections",
                        UnitPrice = 14.0000M, UnitsInStock = 76 },
                      new Product() { ProductID = 26, ProductName = "Gumbär Gummibärchen", Category = "Confections",
                        UnitPrice = 31.2300M, UnitsInStock = 15 },
                      new Product() { ProductID = 27, ProductName = "Schoggi Schokolade", Category = "Confections",
                        UnitPrice = 43.9000M, UnitsInStock = 49 },
                      new Product() { ProductID = 28, ProductName = "Rössle Sauerkraut", Category = "Produce",
                        UnitPrice = 45.6000M, UnitsInStock = 26 },
                      new Product() { ProductID = 29, ProductName = "Thüringer Rostbratwurst", Category = "Meat/Poultry",
                        UnitPrice = 123.7900M, UnitsInStock = 0 },
                      new Product() { ProductID = 30, ProductName = "Nord-Ost Matjeshering", Category = "Seafood",
                        UnitPrice = 25.8900M, UnitsInStock = 10 },
                      new Product() { ProductID = 31, ProductName = "Gorgonzola Telino", Category = "Dairy Products",
                        UnitPrice = 12.5000M, UnitsInStock = 0 },
                      new Product() { ProductID = 32, ProductName = "Mascarpone Fabioli", Category = "Dairy Products",
                        UnitPrice = 32.0000M, UnitsInStock = 9 },
                      new Product() { ProductID = 33, ProductName = "Geitost", Category = "Dairy Products",
                        UnitPrice = 2.5000M, UnitsInStock = 112 },
                      new Product() { ProductID = 34, ProductName = "Sasquatch Ale", Category = "Beverages",
                        UnitPrice = 14.0000M, UnitsInStock = 111 },
                      new Product() { ProductID = 35, ProductName = "Steeleye Stout", Category = "Beverages",
                        UnitPrice = 18.0000M, UnitsInStock = 20 },
                      new Product() { ProductID = 36, ProductName = "Inlagd Sill", Category = "Seafood",
                        UnitPrice = 19.0000M, UnitsInStock = 112 },
                      new Product() { ProductID = 37, ProductName = "Gravad lax", Category = "Seafood",
                        UnitPrice = 26.0000M, UnitsInStock = 11 },
                      new Product() { ProductID = 38, ProductName = "Côte de Blaye", Category = "Beverages",
                        UnitPrice = 263.5000M, UnitsInStock = 17 },
                      new Product() { ProductID = 39, ProductName = "Chartreuse verte", Category = "Beverages",
                        UnitPrice = 18.0000M, UnitsInStock = 69 },
                      new Product() { ProductID = 40, ProductName = "Boston Crab Meat", Category = "Seafood",
                        UnitPrice = 18.4000M, UnitsInStock = 123 },
                      new Product() { ProductID = 41, ProductName = "Jack's New England Clam Chowder", Category = "Seafood",
                        UnitPrice = 9.6500M, UnitsInStock = 85 },
                      new Product() { ProductID = 42, ProductName = "Singaporean Hokkien Fried Mee", Category = "Grains/Cereals",
                        UnitPrice = 14.0000M, UnitsInStock = 26 },
                      new Product() { ProductID = 43, ProductName = "Ipoh Coffee", Category = "Beverages",
                        UnitPrice = 46.0000M, UnitsInStock = 17 },
                      new Product() { ProductID = 44, ProductName = "Gula Malacca", Category = "Condiments",
                        UnitPrice = 19.4500M, UnitsInStock = 27 },
                      new Product() { ProductID = 45, ProductName = "Rogede sild", Category = "Seafood",
                        UnitPrice = 9.5000M, UnitsInStock = 5 },
                      new Product() { ProductID = 46, ProductName = "Spegesild", Category = "Seafood",
                        UnitPrice = 12.0000M, UnitsInStock = 95 },
                      new Product() { ProductID = 47, ProductName = "Zaanse koeken", Category = "Confections",
                        UnitPrice = 9.5000M, UnitsInStock = 36 },
                      new Product() { ProductID = 48, ProductName = "Chocolade", Category = "Confections",
                        UnitPrice = 12.7500M, UnitsInStock = 15 },
                      new Product() { ProductID = 49, ProductName = "Maxilaku", Category = "Confections",
                        UnitPrice = 20.0000M, UnitsInStock = 10 },
                      new Product() { ProductID = 50, ProductName = "Valkoinen suklaa", Category = "Confections",
                        UnitPrice = 16.2500M, UnitsInStock = 65 },
                      new Product() { ProductID = 51, ProductName = "Manjimup Dried Apples", Category = "Produce",
                        UnitPrice = 53.0000M, UnitsInStock = 20 },
                      new Product() { ProductID = 52, ProductName = "Filo Mix", Category = "Grains/Cereals",
                        UnitPrice = 7.0000M, UnitsInStock = 38 },
                      new Product() { ProductID = 53, ProductName = "Perth Pasties", Category = "Meat/Poultry",
                        UnitPrice = 32.8000M, UnitsInStock = 0 },
                      new Product() { ProductID = 54, ProductName = "Tourtière", Category = "Meat/Poultry",
                        UnitPrice = 7.4500M, UnitsInStock = 21 },
                      new Product() { ProductID = 55, ProductName = "Pâté chinois", Category = "Meat/Poultry",
                        UnitPrice = 24.0000M, UnitsInStock = 115 },
                      new Product() { ProductID = 56, ProductName = "Gnocchi di nonna Alice", Category = "Grains/Cereals",
                        UnitPrice = 38.0000M, UnitsInStock = 21 },
                      new Product() { ProductID = 57, ProductName = "Ravioli Angelo", Category = "Grains/Cereals",
                        UnitPrice = 19.5000M, UnitsInStock = 36 },
                      new Product() { ProductID = 58, ProductName = "Escargots de Bourgogne", Category = "Seafood",
                        UnitPrice = 13.2500M, UnitsInStock = 62 },
                      new Product() { ProductID = 59, ProductName = "Raclette Courdavault", Category = "Dairy Products",
                        UnitPrice = 55.0000M, UnitsInStock = 79 },
                      new Product() { ProductID = 60, ProductName = "Camembert Pierrot", Category = "Dairy Products",
                        UnitPrice = 34.0000M, UnitsInStock = 19 },
                      new Product() { ProductID = 61, ProductName = "Sirop d'érable", Category = "Condiments",
                        UnitPrice = 28.5000M, UnitsInStock = 113 },
                      new Product() { ProductID = 62, ProductName = "Tarte au sucre", Category = "Confections",
                        UnitPrice = 49.3000M, UnitsInStock = 17 },
                      new Product() { ProductID = 63, ProductName = "Vegie-spread", Category = "Condiments",
                        UnitPrice = 43.9000M, UnitsInStock = 24 },
                      new Product() { ProductID = 64, ProductName = "Wimmers gute Semmelknödel", Category = "Grains/Cereals",
                        UnitPrice = 33.2500M, UnitsInStock = 22 },
                      new Product() { ProductID = 65, ProductName = "Louisiana Fiery Hot Pepper Sauce", Category = "Condiments",
                        UnitPrice = 21.0500M, UnitsInStock = 76 },
                      new Product() { ProductID = 66, ProductName = "Louisiana Hot Spiced Okra", Category = "Condiments",
                        UnitPrice = 17.0000M, UnitsInStock = 4 },
                      new Product() { ProductID = 67, ProductName = "Laughing Lumberjack Lager", Category = "Beverages",
                        UnitPrice = 14.0000M, UnitsInStock = 52 },
                      new Product() { ProductID = 68, ProductName = "Scottish Longbreads", Category = "Confections",
                        UnitPrice = 12.5000M, UnitsInStock = 6 },
                      new Product() { ProductID = 69, ProductName = "Gudbrandsdalsost", Category = "Dairy Products",
                        UnitPrice = 36.0000M, UnitsInStock = 26 },
                      new Product() { ProductID = 70, ProductName = "Outback Lager", Category = "Beverages",
                        UnitPrice = 15.0000M, UnitsInStock = 15 },
                      new Product() { ProductID = 71, ProductName = "Flotemysost", Category = "Dairy Products",
                        UnitPrice = 21.5000M, UnitsInStock = 26 },
                      new Product() { ProductID = 72, ProductName = "Mozzarella di Giovanni", Category = "Dairy Products",
                        UnitPrice = 34.8000M, UnitsInStock = 14 },
                      new Product() { ProductID = 73, ProductName = "Röd Kaviar", Category = "Seafood",
                        UnitPrice = 15.0000M, UnitsInStock = 101 },
                      new Product() { ProductID = 74, ProductName = "Longlife Tofu", Category = "Produce",
                        UnitPrice = 10.0000M, UnitsInStock = 4 },
                      new Product() { ProductID = 75, ProductName = "Rhönbräu Klosterbier", Category = "Beverages",
                        UnitPrice = 7.7500M, UnitsInStock = 125 },
                      new Product() { ProductID = 76, ProductName = "Lakkalikööri", Category = "Beverages",
                        UnitPrice = 18.0000M, UnitsInStock = 57 },
                      new Product() { ProductID = 77, ProductName = "Original Frankfurter grüne Soße", Category = "Condiments",
                        UnitPrice = 13.0000M, UnitsInStock = 32 }
            };



            CustomerList = XDocument.Load("Customers.xml")
                                              .Root?
                                              .Elements("customer")
                                              .Select(e => new Customer
                                              {
                                                  CustomerID = (string?)e.Element("id") ?? "Unknown",
                                                  CustomerName = (string?)e.Element("name") ?? "No Name",
                                                  Address = (string?)e.Element("address"),
                                                  City = (string?)e.Element("city"),
                                                  Region = (string?)e.Element("region"),
                                                  PostalCode = (string?)e.Element("postalcode"),
                                                  Country = (string?)e.Element("country"),
                                                  Phone = (string?)e.Element("phone"),
                                                  Fax = (string?)e.Element("fax"),

                                                  Orders = e.Element("orders")?
                                                            .Elements("order")
                                                            .Select(o => new Order
                                                            {
                                                                OrderID = int.TryParse((string?)o.Element("id"), out var id) ? id : -1,
                                                                OrderDate = DateTime.TryParse((string?)o.Element("orderdate"), out var dt) ? dt : DateTime.MinValue,
                                                                Total = decimal.TryParse((string?)o.Element("total"), out var t) ? t : 0m
                                                            })
                                                            .ToArray() ?? Array.Empty<Order>()
                                              })
                                              .ToList();



            orders =new List<Order>() {

             new Order { OrderID = 1, OrderDate = new DateTime(2025, 1, 15), Total = 150.75m },
            new Order { OrderID = 2, OrderDate = new DateTime(2025, 2, 10), Total = 300.50m },
            new Order { OrderID = 3, OrderDate = new DateTime(2025, 3, 5), Total = 99.99m },
            new Order { OrderID = 4, OrderDate = new DateTime(2025, 4, 1), Total = 450.00m },
            new Order { OrderID = 5, OrderDate = new DateTime(2025, 4, 15), Total = 120.25m },
            new Order { OrderID = 6, OrderDate = new DateTime(2025, 5, 2), Total = 220.00m },
            new Order { OrderID = 7, OrderDate = new DateTime(2025, 5, 18), Total = 330.10m },
            new Order { OrderID = 8, OrderDate = new DateTime(2025, 6, 4), Total = 85.90m },
            new Order { OrderID = 9, OrderDate = new DateTime(2025, 6, 20), Total = 640.50m },
            new Order { OrderID = 10, OrderDate = new DateTime(2025, 7, 1), Total = 410.75m },
            new Order { OrderID = 11, OrderDate = new DateTime(2025, 7, 15), Total = 250.60m },
            new Order { OrderID = 12, OrderDate = new DateTime(2025, 8, 3), Total = 99.00m },
            new Order { OrderID = 13, OrderDate = new DateTime(2025, 8, 18), Total = 520.40m },
            new Order { OrderID = 14, OrderDate = new DateTime(2025, 9, 7), Total = 310.20m },
            new Order { OrderID = 15, OrderDate = new DateTime(2025, 9, 22), Total = 715.35m },
            new Order { OrderID = 16, OrderDate = new DateTime(2025, 10, 10), Total = 120.99m },
            new Order { OrderID = 17, OrderDate = new DateTime(2025, 10, 25), Total = 305.70m },
            new Order { OrderID = 18, OrderDate = new DateTime(2025, 11, 2), Total = 499.95m },
            new Order { OrderID = 19, OrderDate = new DateTime(2025, 11, 16), Total = 610.00m },
            new Order { OrderID = 20, OrderDate = new DateTime(2025, 12, 1), Total = 85.20m },
            new Order { OrderID = 21, OrderDate = new DateTime(2025, 12, 15), Total = 200.10m },
            new Order { OrderID = 22, OrderDate = new DateTime(2025, 12, 28), Total = 325.45m },
            new Order { OrderID = 23, OrderDate = new DateTime(2025, 1, 6), Total = 710.99m },
            new Order { OrderID = 24, OrderDate = new DateTime(2025, 1, 20), Total = 150.00m },
            new Order { OrderID = 25, OrderDate = new DateTime(2025, 2, 5), Total = 245.30m },
            new Order { OrderID = 26, OrderDate = new DateTime(2025, 2, 19), Total = 380.75m },
            new Order { OrderID = 27, OrderDate = new DateTime(2025, 3, 10), Total = 490.90m },
            new Order { OrderID = 28, OrderDate = new DateTime(2025, 3, 24), Total = 199.99m },
            new Order { OrderID = 29, OrderDate = new DateTime(2025, 4, 8), Total = 350.60m },
            new Order { OrderID = 30, OrderDate = new DateTime(2025, 4, 22), Total = 780.45m },
            new Order { OrderID = 31, OrderDate = new DateTime(2025, 5, 7), Total = 120.00m },
            new Order { OrderID = 32, OrderDate = new DateTime(2025, 5, 21), Total = 305.80m },
            new Order { OrderID = 33, OrderDate = new DateTime(2025, 6, 5), Total = 605.15m },
            new Order { OrderID = 34, OrderDate = new DateTime(2025, 6, 19), Total = 88.99m },
            new Order { OrderID = 35, OrderDate = new DateTime(2025, 7, 3), Total = 470.00m },
            new Order { OrderID = 36, OrderDate = new DateTime(2025, 7, 17), Total = 560.25m },
            new Order { OrderID = 37, OrderDate = new DateTime(2025, 8, 1), Total = 299.50m },
            new Order { OrderID = 38, OrderDate = new DateTime(2025, 8, 15), Total = 400.00m },
            new Order { OrderID = 39, OrderDate = new DateTime(2025, 8, 29), Total = 210.90m },
            new Order { OrderID = 40, OrderDate = new DateTime(2025, 9, 12), Total = 325.00m },
            new Order { OrderID = 41, OrderDate = new DateTime(2025, 9, 26), Total = 555.75m },
            new Order { OrderID = 42, OrderDate = new DateTime(2025, 10, 11), Total = 640.20m },
            new Order { OrderID = 43, OrderDate = new DateTime(2025, 10, 25), Total = 110.00m },
            new Order { OrderID = 44, OrderDate = new DateTime(2025, 11, 9), Total = 199.95m },
            new Order { OrderID = 45, OrderDate = new DateTime(2025, 11, 23), Total = 425.30m },
            new Order { OrderID = 46, OrderDate = new DateTime(2025, 12, 7), Total = 520.00m },
            new Order { OrderID = 47, OrderDate = new DateTime(2025, 12, 21), Total = 315.10m },
            new Order { OrderID = 48, OrderDate = new DateTime(2025, 12, 31), Total = 99.99m },
            new Order { OrderID = 49, OrderDate = new DateTime(2025, 1, 12), Total = 175.50m },
            new Order { OrderID = 50, OrderDate = new DateTime(2025, 2, 25), Total = 260.60m }

            };
                        

        }
    }
}
