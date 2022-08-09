using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int16 ano;

            Console.Write("Qual o ano a verificar? ");
            ano = Int16.Parse(Console.ReadLine());

            if (ano % 4 == 0)
            {
                Console.Write("Esse ano é bissexto");
            }
            else
            {
                Console.Write("Esse ano não é bissexto");
            }

            Console.ReadKey();
        }
    }
}
