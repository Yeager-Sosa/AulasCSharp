using System;

namespace Exercicio_impar_ou_par
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nome;
            Console.WriteLine("Informe o seu nome: ");

            Nome = Console.ReadLine();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine(string.Format("Meu nome é: {0}", Nome));

            Console.ReadKey();
        }
    }
}
