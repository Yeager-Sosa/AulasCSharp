using System;
using System.Globalization;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] vect = new double[n];
            double soma = 0;
            foreach(int i in vect)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                soma += vect[i];
            }
            double media = soma / n;
            Console.WriteLine(soma);
            Console.WriteLine(media.ToString("F2"));
        }
    }
}

