using LINQ_1;
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
        }
    }
}
