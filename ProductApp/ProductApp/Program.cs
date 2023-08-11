using ProductApp.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product
            {
                id = 1,
                name = "Tomato",
                price = 100.0m,
                discountPercentage = 10.0
            };

            Product product2 = new Product
            {
                id = 2,
                name = "Horlicks",
                price = 80.0m,
                discountPercentage = 15.0
            };

            Console.WriteLine("Product 1 Details:");
            Console.WriteLine($"ID: {product1.id}");
            Console.WriteLine($"Name: {product1.name}");
            Console.WriteLine($"Price: Rs: {product1.price}");
            Console.WriteLine($"Discount Percentage: {product1.discountPercentage}%");
            Console.WriteLine($"Price After Discount: Rs {product1.CalculateCostAfterDiscount()}");

            Console.WriteLine("-------------------------------------------------------------------------------");

            Console.WriteLine("Product 2 Details:");
            Console.WriteLine($"ID: {product2.id}");
            Console.WriteLine($"Name: {product2.name}");
            Console.WriteLine($"Price: Rs {product2.price}");
            Console.WriteLine($"Discount Percentage: {product2.discountPercentage}%");
            Console.WriteLine($"Price After Discount: Rs {product2.CalculateCostAfterDiscount()}");
        }
    }
}
