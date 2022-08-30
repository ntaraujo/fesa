using System;

namespace aula18._4
{
    class Program
    {
        static void MostraTabuada(int numero)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            MostraTabuada(int.Parse(Console.ReadLine()));
        }
    }
}
