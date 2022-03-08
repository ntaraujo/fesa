using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomeAluno;
            float nota1, nota2, media;

            Console.Write("Nome do aluno: ");
            nomeAluno = Console.ReadLine();


            Console.Write("Valor da N1: ");
            nota1 = float.Parse(Console.ReadLine());


            Console.Write("Valor da N2: ");
            nota2 = float.Parse(Console.ReadLine());


            media = nota1 * 0.4f + nota2 * 0.6f;
            Console.Write($"\nA média de {nomeAluno} foi {media}");

            Console.ReadKey();
        }
    }
}
