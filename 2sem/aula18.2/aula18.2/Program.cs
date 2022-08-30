using System;

namespace aula18._2
{
    class Program
    {
        static void EscreveVogais(string nome)
        {
            foreach (char letra in nome.Normalize())
            {
                if ("aeiou".Contains(letra))
                {
                    Console.Write(letra);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Digite um nome: ");
            EscreveVogais(Console.ReadLine());
        }
    }
}
