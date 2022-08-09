using System;

namespace aula15._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Valor 1: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.Write("Valor 2: ");
            int valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine((valor1 > valor2) ? valor1 : valor2);
        }
    }
}
