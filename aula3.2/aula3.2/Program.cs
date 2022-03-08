using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int16 ano;

            Console.Write("Qual o número a verificar? ");
            ano = Int16.Parse(Console.ReadLine());

            if (ano % 2 == 0)
            {
                Console.Write("Esse número é par");
            }
            else
            {
                Console.Write("Esse número não é par");
            }

            Console.ReadKey();
        }
    }
}