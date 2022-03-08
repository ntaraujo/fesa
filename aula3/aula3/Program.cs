using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b, m;
            float x;

            Console.Write("Digite o valor de B: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de M: ");
            m = int.Parse(Console.ReadLine());

            if (m == 0)
            {
                Console.Write("Impossível dividir por 0");
            }
            else
            {
                x = (float)b / m;
                Console.Write($"O valor de X = {x}");
            }

            Console.ReadKey();
        }
    }
}
