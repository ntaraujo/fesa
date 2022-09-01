using System;

namespace aula15._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Valor 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Valor 2: ");
            int num2 = int.Parse(Console.ReadLine());

            int num1antigo = num1;

            num1 = (num2 > num1) ? num2 : num1;
            num2 = (num1 != num1antigo) ? num1antigo : num2;

            Console.WriteLine(num1 + " " + num2);

        }
    }
}
