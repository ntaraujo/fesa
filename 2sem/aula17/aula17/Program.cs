using System;

namespace aula17
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("RG: ");
                string rg = Console.ReadLine();

                int rg_soma = 0;

                for (int i = 0; i < 8; i++)
                {
                    rg_soma += (rg[i] - '0') * (9 - i);
                }

                bool valido = rg_soma % 11 == rg[8] - '0';
                Console.WriteLine("O RG é " + (valido ? "válido" : "falso"));
            }
        }
    }
}
