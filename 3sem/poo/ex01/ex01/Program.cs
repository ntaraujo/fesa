using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Jogo> lista_jogos = new List<Jogo>();
            do
            {
                Jogo jogo_instancia = new Jogo();

                lista_jogos.Add(jogo_instancia);

                Console.WriteLine($"Cadastro do jogo ({lista_jogos.Count}/10):\n\n");

                while (true)
                {
                    Console.Write("Código: ");
                    try
                    {
                        jogo_instancia.codigo = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }

                while (true)
                {
                    Console.Write("Nome: ");
                    try
                    {
                        jogo_instancia.nome = Console.ReadLine();
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }

                while (true)
                {
                    Console.Write("Categoria: ");
                    try
                    {
                        jogo_instancia.categoria = Console.ReadLine();
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }

                while (true)
                {
                    Console.Write("Data de Lançamento: ");
                    try
                    {
                        jogo_instancia.data_de_lancamento = DateTime.Parse(Console.ReadLine());
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }

                Console.Write("Adicionar mais um cadastro? s/N?");
                if (Console.ReadLine().Trim().ToLower() != "s")
                {
                    break;
                }

            } while (lista_jogos.Count < 10);

            Console.WriteLine("Todos os Cadastros:");

            foreach (Jogo jogo_instancia in lista_jogos)
            {
                Console.WriteLine($"Código =  {jogo_instancia.codigo}; Nome = {jogo_instancia.nome} ; Categoria = {jogo_instancia.categoria} ; Data de Lançamento = {jogo_instancia.data_de_lancamento}");
            }
            Console.ReadKey();
        }
    }
}
