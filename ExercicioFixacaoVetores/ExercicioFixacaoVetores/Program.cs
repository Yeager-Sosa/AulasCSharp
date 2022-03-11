using System;

namespace ExercicioFixacaoVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudante[] vect = new Estudante[10];
            Console.WriteLine("digite a quantidade de estudantes que vão alugar quartos");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o nome do aluno");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o email do aluno");
                string email = Console.ReadLine();
                Console.WriteLine("digite o quarto que deseja alugar de 0 a 9");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Estudante(nome, email);
            }
            for (int i = 0; i < vect.Length; i++)
            {
                if(vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}

