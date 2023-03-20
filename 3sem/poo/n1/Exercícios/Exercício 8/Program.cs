using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            exibição("Exemplo de texto centralizado");
            exibição("Texto em vermelho", ConsoleColor.Red);
            Console.ReadKey();
        }
        public static void exibição(string texto)
        {
            int posicaoTexto = (Console.WindowWidth + texto.Length) / 2;
            Console.WriteLine("{0," + posicaoTexto + "}", texto);
        }

        public static void exibição(string texto, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            exibição(texto);
            Console.ResetColor();
        }
        
    }
}
