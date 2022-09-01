using System;

namespace aula16
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Digite um número: ");
                int num = int.Parse(Console.ReadLine());

                string saida = "";

                do
                {
                    saida = $"{num % 2}{saida}";
                    num /= 2;
                } while (num >= 2);
                if (num % 2 != 0)
                {
                    saida = $"1{saida}";
                }

                Console.WriteLine($"Em binário: {saida}");
            }
        }
    }
}
