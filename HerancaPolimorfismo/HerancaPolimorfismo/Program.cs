using System;
using System.Collections.Generic;
using HerancaPolimorfismo.Entities;
using System.Globalization;
namespace HerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            Console.Write("Digite a quantidade de funcionarios que deseja cadastrar: ");
            int amountEmployee = int.Parse(Console.ReadLine());
            for (int i = 1; i <= amountEmployee; i++)
            {
                Console.WriteLine($"Funcionario numero #{i}");
                Console.Write("Funcionario terceirizado (s/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Digite o nome do funcionario: ");
                string name = Console.ReadLine().ToString();
                Console.Write("Digite as horas do funcionario: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Digite o valor da hora do funcionario: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 's' || ch == 'S')
                {
                    Console.Write("Digite a despesa adicional: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
            }
            Console.WriteLine();
            Console.WriteLine("-----PAGAMENTOS-----"); //resultado abaixo é uma polimorfia do metodo payment
            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + "- $" + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
