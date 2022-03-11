using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> qualquerCoisa = new List<string> {"Gustavo", "Ana", "Carlos","Felipe", "Airton", "Roberto", "Amanda", "Wilson" };
           /* qualquerCoisa.Remove("Ana");
            qualquerCoisa.RemoveAt(2);
            qualquerCoisa.RemoveAll(x => x[0] == 'A'); */
            qualquerCoisa.RemoveRange(1, 4);
            foreach (string nome in qualquerCoisa)
            {
                Console.WriteLine(nome);
                
                
            }
            List<string> qualquerCoisa2 = qualquerCoisa.FindAll(x => x[0] == 'A');
            foreach(string nome in qualquerCoisa2)
            {
                Console.WriteLine(nome);
              
            }
          
        }
    }
}
