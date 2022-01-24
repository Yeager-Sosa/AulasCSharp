using System;

class Aluno
{
    //atributos
    private double nota1, nota2;

    private double media()
    {
        return (nota1+nota2)/2;
    }

    public void mensagem()
    {
        Console.WriteLine("informe a primeira nota");
        nota1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("informe a segunda nota");
        nota2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("A media é "+media());
    }
}