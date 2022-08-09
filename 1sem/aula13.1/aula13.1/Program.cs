using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula13._1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int[,] matriz = new int[4, 3];
            int[] pares = { 0, 0, 0, 0 };
            int numero;

            // preenchendo
            for (int linha = 0; linha < 4; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write($"Digite a matriz[{linha}, {coluna}]: ");
                    numero = int.Parse(Console.ReadLine());

                    matriz[linha, coluna] = numero;
                    if (numero % 2 == 0) pares[linha]++;
                }
                Console.WriteLine();
            }

            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                Console.WriteLine($"Pares na linha {linha}: {pares[linha]}");
            }

        }
    }
}