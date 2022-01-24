using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace POO
{
    class Program
    {
        static void Main(string[] args){
            //instanciar objeto
            Pessoa obj = new Pessoa();
            obj.nome = "Gustavo";
            obj.idade = 27;
            obj.mensagem();
        }
    }
}