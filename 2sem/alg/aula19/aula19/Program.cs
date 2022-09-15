using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace aula19
{
    class Program
    {
        static string ARQUIVO = @"Z:\repos\fesa\2sem\alg\aula19\teste.txt";
        static void Main(string[] args)
        {
            bool continuar = true;
            while (continuar)
            {
                Console.Write("Nova estudante: ");
                string novaLinha = Console.ReadLine();

                if (novaLinha.Length == 0)
                {
                    continuar = false;
                }
                else
                {
                    File.AppendAllText(ARQUIVO, novaLinha + "\n");
                }
                
            }
        }
    }
}
