using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula2Ola
{
    class Program
    {
        static void Main(string[] args)
        {
            //Codigo aqui dentro, entendeu?!
            string saudacao = "ola ",nome;
            Console.WriteLine("Digite o seu Nome:");
            nome = Console.ReadLine();
            Console.Write(saudacao + nome );
            Console.ReadKey();
        }
    }
}
