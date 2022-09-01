using System;

namespace aula15._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int[3];

            Console.Write("Valor 1: ");
            valores[0] = int.Parse(Console.ReadLine());

            Console.Write("Valor 2: ");
            valores[1] = int.Parse(Console.ReadLine());

            Console.Write("Valor 3: ");
            valores[2] = int.Parse(Console.ReadLine());

            Array.Sort(valores);

            foreach (int valor in valores)
            {
                Console.Write(valor + " ");
            }
        }
    }
}
