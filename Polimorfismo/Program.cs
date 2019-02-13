using System;
using Polimorfismo.Entities;
using System.Collections.Generic;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> prod = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char c = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (c == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    UsedProduct pU = new UsedProduct(name, price, date);
                    prod.Add(pU);
                } if (c == 'i')
                {
                    Console.Write("Customs fee: ");
                    double fee = double.Parse(Console.ReadLine());

                    ImportedProduct pI = new ImportedProduct(name, price, fee);
                    prod.Add(pI);
                } if (c == 'c')
                {
                    Product pC = new Product(name, price);
                    prod.Add(pC);
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");

            foreach (Product p in prod)
            {
                Console.WriteLine(p.PriceTag());
            }

        }
    }
}
