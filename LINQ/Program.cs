using LINQ.Models;
using System.Drawing;
using System.Xml.Linq;
using static LINQ.DataSources.Source;
namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1
            //// 1.Get all products from the "Seafood" category.Print
            ////each product's name and price.
            //var allProductSeaFood = ProductList.Where(p => p.Category =="Seafood")
            //    .Select(p => new {p.ProductName,p.UnitPrice});
            //foreach(var seafood in allProductSeaFood)
            //{
            //    Console.WriteLine(seafood.ProductName);
            //    Console.WriteLine(seafood.UnitPrice);
            //}
            #endregion
            #region Question2
            ////2.Get a list of only the product names from ProductList.
            ////Print each name.
            //var ProductName = ProductList.Select(p => new { p.ProductName });
            //foreach(var product in ProductName) {  Console.WriteLine(product.ProductName); }
            #endregion
            #region Question3
            ////3.Get all products where UnitPrice is between 10 and 30
            //var ProductFilteredPrice = ProductList
            //    .Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);
            //foreach (var Product in ProductFilteredPrice)

            //    { 
            //Console.WriteLine(Product);
            //}
            #endregion
            #region Question4
            ////            4.Get all products that are in stock(UnitsInStock >
            ////0) and belong to the "Condiments" category.
            //var ProductInStock = ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");
            //foreach (var Product in ProductInStock) {
            //    Console.WriteLine($"{Product.ProductName} - {Product.UnitPrice}");
            //}

            #endregion
            #region Question5
            ////            5.Create a new anonymous type with three
            ////properties: ● Name → the product name
            ////● Price → the unit price
            ////● StockStatus → a string: "Available" if
            ////UnitsInStock > 0, otherwise "Out of Stock"
            ////● Print the result.

            //var Product = ProductList.Select(p => new { Name = p.ProductName, Price = p.UnitPrice, StockStatus = p.UnitsInStock > 0 ? "Availlable" : "Out Of Stock" });
            //foreach (var item in Product) { 
            //Console.WriteLine($"Name{item.Name}, Price: {item.Price}, Stock: {item.StockStatus}");
            //}


            //}

            #endregion
            #region Question6
            ////        6. Print each product's name along with its position
            ////(1-based) in the list.Expected format: 1. Chai, 2.
            ////Chang, etc.

            //var ProductInexed = ProductList.Select((p, i) => $"{i + 1},{p.ProductName}");
            //foreach (var p in ProductInexed) { 
            //Console.WriteLine(p);
            //}

            #endregion

        }
    }
}

