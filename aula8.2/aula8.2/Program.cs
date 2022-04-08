using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto;
            bool palindromo = true;

            Console.Write("Digite uma palavra ou frase: ");
            texto = Console.ReadLine().Replace(" ", "");

            for (int i = 0; i<texto.Length/2; i++)
            {
                if (texto[i] != texto[texto.Length - i - 1])
                {
                    palindromo = false;
                    break;
                }
            }

            if (palindromo)
            {
                Console.WriteLine("É um palíndromo");
            }
            else
            {
                Console.WriteLine("Não é um palíndromo");
            }

            Console.ReadKey();
        }
    }
}
