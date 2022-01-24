using System;

class Pessoa
{
    // Atributos
    public string nome;
    public int idade;

    //metodos
    public void mensagem()
    {
        Console.WriteLine("Olá " + nome + " voce tem " + idade + " anos");
    }
}