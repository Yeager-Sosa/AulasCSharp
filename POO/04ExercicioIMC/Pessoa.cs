using System;

class Pessoa
{
    // ATRIBUTOS
    public double peso, altura;

    //METODO
    public double imc()
    {
        return peso / (altura * altura);
    }

    public void rankingImc()
    {
        double obterImc = Math.Round(imc(), 2);
        if (obterImc <= 18.5) Console.WriteLine("Seu iMC é de: " + obterImc + " voce esta abaixo do peso");
        else if (obterImc > 18.5 && obterImc <= 25) Console.WriteLine("Seu iMC é de: " + obterImc + " voce esta no peso normal");
        else if (obterImc > 25 && obterImc <= 30) Console.WriteLine("Seu iMC é de: " + obterImc + " voce esta acima do peso");
        else if (obterImc > 30 && obterImc <= 35) Console.WriteLine("Seu iMC é de: " + obterImc + " voce esta na obesidade 1");
        else if (obterImc > 35 && obterImc < 40) Console.WriteLine("Seu iMC é de: " + obterImc + " voce esta na obesidade 2");
        else if (obterImc >= 40) Console.WriteLine("Seu iMC é de: " + obterImc + " voce esta na obesidade 3");
    }
}