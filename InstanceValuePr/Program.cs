using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.name = "감자";
            product.price = 2000; 
        }
    }
}