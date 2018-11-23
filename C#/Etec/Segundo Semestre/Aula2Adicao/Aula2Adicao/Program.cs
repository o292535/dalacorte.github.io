using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula2Adicao
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor, valor2, soma; 
            Console.WriteLine("Digite o primeiro valor");
            valor = Convert .ToInt32(Console.Read());
            Console.WriteLine("Digite o Segundo Valor");
            valor2 = Convert.ToInt32(Console.Read());  
            Console.Write(valor);
            Console.Write(valor2);
            soma = valor + valor2;
            Console.Write(soma);
            Console.ReadKey();
        }
    }
}
