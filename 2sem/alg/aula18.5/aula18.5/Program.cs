using System;

namespace aula18._5
{
    class Program
    {
        static int MenorValor(int[] valores)
        {
            int menor = valores[0];
            
            foreach (int valor in valores)
            {
                if (valor < menor)
                {
                    menor = valor;
                }
            }

            return menor;
        }

        static void Main(string[] args)
        {
            int[] valores = { 1, 4, 0 };
            Console.WriteLine(MenorValor(valores));
        }
    }
}
