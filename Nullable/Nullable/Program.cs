using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            double? x = null; // para usar valor nulo em variavel
            double? y = 10;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);
            //  x = 1;
            if (x.HasValue) Console.WriteLine(x.Value);
            else Console.WriteLine("X is Null");
            x = 500;
            y = x ?? 700; // ?? operador de coalescência nula
            Console.WriteLine("Y é igual a: "+ y);

        }
    }
}

