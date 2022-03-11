using System;
using System.Collections.Generic;
using ExercicioPolimorfismoHeranca.Entities;
using System.Globalization;
namespace ExercicioPolimorfismoHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            Console.Write("Enter the number of products: ");
            int amountProducts = int.Parse(Console.ReadLine());
            for (int i = 1; i <= amountProducts; i++)
            {
                Console.WriteLine($"Product #{i}:");
                Console.Write("Common, used or imported (c/u/i)?: ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'u' || ch == 'U')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufactureDate));
                }
                else if (ch == 'i' || ch == 'I')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, customsFee));
                }
                else
                {
                    list.Add(new Product(name, price));
                }

            }
            Console.WriteLine("-----PRICE TAGS-----");
            foreach (Product product in list)
            {
                Console.WriteLine(product.Name + product.PriceTag());
            }
        }
    }
}
