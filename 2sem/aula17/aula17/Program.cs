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

                for (int i = 0, ajudador = 9; i < 8; i++, ajudador--)
                {
                    rg_soma += (rg[i] - '0') * ajudador;
                }

                bool valido = rg_soma % 11 == rg[rg.Length - 1] - '0';
                Console.WriteLine("O RG é " + (valido ? "válido" : "falso"));
            }
        }
    }
}
