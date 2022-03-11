using System;
using System.Collections.Generic;
using ClasseAbstrata.Entities;
using ClasseAbstrata.Entities.Enums;
namespace ClasseAbstrata
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();
            Console.Write("Enter the number of shapes: ");
            int amount = int.Parse(Console.ReadLine());
            for (int i = 1; i <= amount; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Rectangle or Cicle (r/c)? ");
                char recOrCic = char.Parse(Console.ReadLine());
                if (recOrCic == 'r')
                {
                    Console.Write("Color (Black/Blue/Red): ");
                    Color color = Enum.Parse<Color>(Console.ReadLine());
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Heigth: ");
                    double heigth = double.Parse(Console.ReadLine());
                    list.Add(new Rectangle(width, heigth, color));
                }
                else
                {
                    Console.Write("Color (Black/Blue/Red): ");
                    Color color = Enum.Parse<Color>(Console.ReadLine());
                    Console.Write("Radius: ");
                    double radio = double.Parse(Console.ReadLine());
                    list.Add(new Circle(radio, color));
                }


            }
            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2"));
            }


        }
    }
}
