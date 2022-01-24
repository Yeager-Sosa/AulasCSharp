// See https://aka.ms/new-console-template for more information

using System;

namespace _05Acesso
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            p.nome = "gustavo";
            Console.WriteLine("seu nome é: "+p.nome);
        }
    }
}
