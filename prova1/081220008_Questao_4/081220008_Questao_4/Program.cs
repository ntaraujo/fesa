using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _081220008_Questao_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[1000, 1000];
            Random rnd = new Random();
            bool identidade = true;

            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < 1000; j++)
                {
                    matriz[i, j] = rnd.Next(0, 2);

                    if ((i == j && matriz[i, j] == 0) || (i != j && matriz[i, j] == 1))
                    {
                        identidade = false;
                    }
                }
            }

            if (identidade)
            {
                Console.WriteLine("A matriz é uma matriz identidade");
            }
            else
            {
                Console.WriteLine("A metriz não é uma matriz identidade");
            }
        }
    }
}
