using System;

namespace aula16._2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Digite uma base menor ou igual a 10: ");
                int baseNum = int.Parse(Console.ReadLine());
                if (baseNum > 10) continue;

                Console.Write("Digite um número: ");
                int num = int.Parse(Console.ReadLine());

                string saida = "";

                do
                {
                    saida = $"{num % baseNum}{saida}";
                    num /= baseNum;
                } while (num >= 2);
                if (num % baseNum != 0)
                {
                    saida = $"1{saida}";
                }

                Console.WriteLine($"Na base {baseNum}: {saida}");
            }
        }

    }
}
