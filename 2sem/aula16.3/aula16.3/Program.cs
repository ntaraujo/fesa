using System;

namespace aula16._3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Digite uma base menor ou igual a 91: ");
                int baseNum = int.Parse(Console.ReadLine());
                if (baseNum > 91) continue;

                Console.Write("Digite um número: ");
                int num = int.Parse(Console.ReadLine());

                string saida = "";
                int cod;

                do
                {
                    cod = num % baseNum;
                    if (cod < 48)
                    {
                        cod += 48;
                    }
                    else if (cod < 65)
                    {
                        cod += 65;
                    }
                    saida = $"{(char)cod}{saida}";
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
