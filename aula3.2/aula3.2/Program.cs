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
            Int16 numero;

            Console.Write("Qual o número a verificar? ");
            numero = Int16.Parse(Console.ReadLine());

            if (numero % 2 == 0)
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