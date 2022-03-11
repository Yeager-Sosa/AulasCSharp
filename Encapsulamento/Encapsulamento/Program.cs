using System;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);
            p.Nome = "TV Plasma";   //chamada da property, nao precisa de parenteses pois não é um metodo
            //p.Quantidade = 15; isso nao funciona pois não tem o set na minha property
            Console.WriteLine(p.Nome); 
            Console.WriteLine(p.Quantidade);
        }
    }
}
