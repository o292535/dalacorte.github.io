using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula2Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            string aluno;
            double nota1, nota2, nota3, nota4, media;
            Console.WriteLine("Digite o seu nome:");
            aluno = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Digite a Primeira Nota:");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a Segunda Nota:");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a Terceira Nota:");
            nota3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a Quarta Nota:");
            nota4 = Convert.ToDouble(Console.ReadLine());
            media = nota1 + nota2 + nota3 + nota4;
            Console.WriteLine("Soma das notas" + media);
            media = media / 4;
            Console.WriteLine("Sua media dividido por 4 "+ media);
            Console.ReadKey();
        }
    }
}
