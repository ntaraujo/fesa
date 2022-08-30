using System;

namespace aula18
{
    class Program
    {
        static bool TemEspaco(string texto)
        {
            return texto.Contains(' ');
        }

        static void Main(string[] args)
        {
            Console.Write("Digite algo: ");
            if (TemEspaco(Console.ReadLine()))
            {
                Console.WriteLine("O que você digitou tem espaço");
            }
            else
            {
                Console.WriteLine("O que você digitou não tem espaço");
            }
        }
    }
}
