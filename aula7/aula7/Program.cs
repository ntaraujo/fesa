using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;

            do
            {
                Console.WriteLine(contador);
                contador++;
            }
            while (contador <= 10);

            Console.ReadKey();
        }
    }
}
