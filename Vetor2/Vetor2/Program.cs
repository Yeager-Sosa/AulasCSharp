using System;
using System.Globalization;

namespace Vetor2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite a quantidade de produtos que irá cadastrar");
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];
            double soma = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o nome do produto");
                string name = Console.ReadLine();
                Console.WriteLine("Digite o preço do produto");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Name = name, Price = price };
                soma += vect[i].Price;
            }
            double media = soma / n;
            Console.WriteLine("a media dos valores dos produtos em estoque é: " + media.ToString("F2"));

        }
    }
}

