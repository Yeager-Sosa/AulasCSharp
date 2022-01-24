// See https://aka.ms/new-console-template for more information
using System;

namespace _04ExercicioEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            p.peso = 80;
            p.altura = 1.80;
            p.rankingImc();
        }
    }
}