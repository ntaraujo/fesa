using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] matrix = new int[99999999];

            Console.WriteLine("DESORDENADO:");
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = random.Next(1, 99999999);
                Console.Write($"{matrix[i]}\t");
            }
            Console.WriteLine();

            int temp;

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = i + 1; j < matrix.Length; j++)
                {
                    if (matrix[j] < matrix[i])
                    {
                        temp = matrix[i];
                        matrix[i] = matrix[j];
                        matrix[j] = temp;
                    }
                }
            }

            Console.WriteLine("ORDENADO:");
            foreach (int n in matrix)
            {
                Console.Write($"{n}\t");
            }
            Console.WriteLine();
        }
    }
}
