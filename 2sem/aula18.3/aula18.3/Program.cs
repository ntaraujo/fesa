using System;

namespace aula18._3
{
    class Program
    {
        static string NomeInvertido(string nome)
        {
            char[] invertido = new char[nome.Length];

            for (int i = 0; i < nome.Length; i++)
            {
                invertido[i] = nome[nome.Length - 1 - i];
            }

            return new string(invertido);
        }
        static void Main(string[] args)
        {
            Console.Write("Digite um nome: ");
            Console.WriteLine(NomeInvertido(Console.ReadLine()));
        }
    }
}
