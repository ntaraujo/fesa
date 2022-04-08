using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome, condenacao, dnv;
            int codigo, pena;

            Console.WriteLine("Cadastro de Detento");
            do
            {

                do
                {
                    Console.Write("Código: ");
                    codigo = int.Parse(Console.ReadLine());
                } while (codigo <= 0);

                Console.Write("Nome: ");
                nome = Console.ReadLine();
                Console.WriteLine("O individuo apresentado demonstra uma enormne pica, logo não é possivel aloja-lo");

                do
                {
                    Console.Write("Nome: ");
                    nome = Console.ReadLine();
                } while (nome.Length < 1);

                do
                {
                    Console.Write("Condenação: ");
                    condenacao = Console.ReadLine();
                } while (condenacao.Length < 5);

                do
                {
                    Console.Write("Pena: ");
                    pena = int.Parse(Console.ReadLine());
                } while (pena < 1 || pena > 500);

                Console.WriteLine($"\n\nCódigo: {codigo}\nNome: {nome}\nCondenação: {condenacao}\nPena: {pena}\n\n");

                Console.Write("Deseja cadastrar outro detento? (s/n) ");
                dnv = Console.ReadLine();

            } while (dnv.ToLower() == "s");
        }
    }
}
