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
            Console.WriteLine(product);

            List<student> list = new List<student>();
            list.Add(new student() { name = "무민", grade = 1 });
            list.Add(new student() { name = "무민마마", grade = 2 });
            list.Add(new student() { name = "무민파파", grade = 3 });

            List<student> list1 = new List<student>()
            {
                new student() { name = "무민", grade = 1 },
                new student() { name = "무민마마", grade = 2 },
                new student() { name = "무민파파", grade = 3 }
            };

            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }

            // Remove기준이 객체임
            // 기존 3개에서 할당하다가 할당하던 값이 사라짐 > 오류발생
            /*foreach (var item in list1)
            {
                if (item.grade == 3)
                {
                    list1.Remove(item);
                }
            }

            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }*/

            // 순서가 이상해지는 문제 발생 > 뒤에서부터 삭제하면 됨 
            /*for (int i = 0; i < 3; i++)
            {
                if (list1[i].grade == 3)
                {
                    list1.RemoveAt(1);
                }
            }*/

            for (int i = list1.Count-1; i >= 0; i--)
            {
                if (list1[i].grade == 3)
                {
                    list1.RemoveAt(1);
                }
            }


            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }
        }
    }
}