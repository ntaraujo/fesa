using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _081220008_Questao_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] numeros = new int[1000];
            int media = 0;

            for (int i = 0; i < 1000; i++)
            {
                numeros[i] = rnd.Next();
                media += numeros[i] / 1000;
            }

            Console.WriteLine($"Vetor de 1000 entradas gerado.\n" +
                $"A média delas é {media}.\n" +
                $"Os números abaixo dessa média são:\n");

            foreach (int n in numeros)
            {
                if (n < media)
                {
                    Console.WriteLine(n);
                }
            }
        }
    }
}
