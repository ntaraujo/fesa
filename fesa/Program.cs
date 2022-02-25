using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fesa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // criando variaveis

            String nome;
            Int16 idade;

            // entrada de dados

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            idade = Int16.Parse(Console.ReadLine());

            // saida de dados
            Console.WriteLine();
            Console.Write($"Olá {nome}, seja bem vindo. \n");
            Console.Write($"Você tem {idade} anos de idade");

            Console.ReadKey();
        }
    }
}
