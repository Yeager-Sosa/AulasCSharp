using System;
using System.Globalization;
namespace MembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Entre o valor do raio");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = Calculadora.Circunferencia(raio); //por ser membro estatico, posso chamar Calculadora.Metodo sem instanciar antes
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferencia " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de pi " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}