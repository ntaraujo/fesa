using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*2.	Utilizando a classe jogo criada no exercício anterior, faça um programa que instancie até 10 jogos. Após efetuar os cadastros, exiba os dados em vídeo.
            Encapsule os atributos. Validações:

            Código -  (int)  ( > 0)
            Nome  - (string)  (obrigatório)
            Categoria – (string)  (válido apenas “ação”  “luta” “tiro” e “Esportes” )
            Data de lançamento -  (DateTime) (deve ser  inferior à data atual)
            */
            List<Jogo> jogos = new List<Jogo>() { };
            string continuar = "N";
            do
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

                Console.WriteLine("Deseja continuar adicionando jogos? [S]/[N] \nEspaços restantes = " + (10-jogos.Count) );
                continuar = Console.ReadLine().ToUpper();
                jogos.Add(jogo);
            }
            while (jogos.Count <= 10 && continuar == "S");
            Console.Clear();

            foreach (Jogo jogo in jogos)
            {
                Console.WriteLine("Informações do jogo:");
                Console.WriteLine(jogo.GetCódigo());
                Console.WriteLine(jogo.GetNome());
                Console.WriteLine(jogo.GetCategoria());
                Console.WriteLine(jogo.GetData_de_lançamento());
            }

            Console.ReadKey();

        } 
    }
}
