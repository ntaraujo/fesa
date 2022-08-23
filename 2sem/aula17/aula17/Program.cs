using System;

namespace aula17
{
    class Program
    {
        static void Main(string[] args)
        {
            string rg = "350983185";

            int[] rg_multiplicado = new int[8];

            for (int i = 0, ajudador = 9; i < 7; i++, ajudador--)
            {
                rg_multiplicado[i] = (rg[i] - '0') * ajudador;
            }

            int rg_soma = 0;

            foreach (int n in rg_multiplicado)
            {
                rg_soma += n;
            }

            bool valido = rg_soma % 11 == Convert.ToInt32(rg[rg.Length - 1]);
            Console.WriteLine(rg[rg.Length - 1] - '0');
            Console.WriteLine("O RG é " + (valido ? "válido" : "falso"));
        }
    }
}
