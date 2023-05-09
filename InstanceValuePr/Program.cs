using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // java st
            Product product = new Product();
            product.name = "감자";
            product.price = 2000;

            // c# st
            Product product1 = new Product() { name = "고구마", price = 2100 };
            Product product2 = new Product() { name = "옥수수" };
            Product product3 = new Product() { price = 90000 };
            Product product4 = new Product() { price = 2100, name = "고구마" }; // 순서 바꿔서도 가능

            Console.WriteLine(Product.origin);
            Console.WriteLine(product.name+ "/" +product.price);
            Console.WriteLine(product.ToString());

            List<student> list = new List<student>();
            list.Add(new student() { name = "무민", grade = 1 });
            list.Add(new student() { name = "무민마마", grade = 2 });
            list.Add(new student() { name = "무민파파", grade = 3 });
        }
    }
}