using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3,4];

            // preenchendo
            for (int linha=0; linha<3; linha++)
            {
                for (int coluna=0; coluna<4; coluna++)
                {
                    Console.Write($"Digite matriz[{linha}, {coluna}]: ");
                    matriz[linha, coluna] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            for (int linha=0; linha<matriz.GetLength(0); linha++)
            {
                for (int coluna=0; coluna<matriz.GetLength(1); coluna++)
                {
                    Console.Write($"{matriz[linha, coluna]}\t");
                }
                Console.WriteLine();
            }

        }
    }
}
