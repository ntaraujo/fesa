using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula9._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome, sobrenome = "";
            int espaco, letra;

            Console.Write("Informe um nome: ");
            nome = Console.ReadLine();
            espaco = nome.IndexOf(' ');
            letra = nome.ToLower().LastIndexOfAny("abcdefghijklmnopqrstuvwxyz".ToCharArray());

            if (letra < espaco)
            {
                Console.Write("Sobrenome não encontrado");
            }
            else
            {
                for (int i = espaco+1; i < nome.Length; i++)
                {
                    sobrenome += nome[i];
                }
                Console.Write($"Seu sobrenome é: {sobrenome}");
            }

            Console.ReadKey();
        }
    }
}
