using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
        Jogo jogo = new Jogo();
            do
            {
                try
                {
                    Console.WriteLine("Digite o código: ");
                    jogo.SetCódigo(Convert.ToInt32(Console.ReadLine()));
                    break;
                }
                catch (Exception erro)
                {
                    Console.WriteLine(erro.Message);
                }
            }
            while (true); 

            do
            {
                try
                {
                    Console.WriteLine("Digite o nome: ");
                    jogo.SetNome(Console.ReadLine());
                    break;
                }
                catch (Exception erro)
                {
                    Console.WriteLine(erro.Message);
                }
            }
            while (true);

            do
            {
                try
                {
                    Console.WriteLine("Digite a categoria: ");
                    jogo.SetCategoria(Console.ReadLine());
                    break;
                }
                catch (Exception erro)
                {
                    Console.WriteLine(erro.Message);
                }
            }
            while (true);
            do
            {
                try
                {
                    Console.WriteLine("Digite a data: ");
                    jogo.SetData_de_lançamento(Convert.ToDateTime(Console.ReadLine()));
                    break;
                }
                catch (Exception erro)
                {
                    Console.WriteLine(erro.Message);
                }
            }
            while (true);

            Console.WriteLine(
                $"Código: {jogo.GetCódigo()}\n" +
                $"Nome: {jogo.GetNome()}\n" +
                $"Categoria: {jogo.GetCategoria()}\n" +
                $"Data de lançamento: {jogo.GetData_de_lançamento()}");
            Console.ReadKey();
        }
    }
}
