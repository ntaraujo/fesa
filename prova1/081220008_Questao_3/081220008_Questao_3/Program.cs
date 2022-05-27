using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _081220008_Questao_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool errado;

            string[] nomes = new string[100];
            string nome_aux;
            int index_espaco;

            int[] idades = new int[100];
            int idade_aux;
            int maior_idade = 0, index_maior_idade = 0;

            for (int i = 0; i < 3; i++)
            {
                do
                {
                    Console.Write("Seu nome completo: ");
                    nome_aux = Console.ReadLine();

                    index_espaco = nome_aux.LastIndexOf(' ');
                    if (index_espaco == -1 || index_espaco == 0 || index_espaco == nome_aux.Length - 1)
                    {
                        Console.WriteLine("O nome tem que ter pelo menos 2 palavras.");
                        errado = true;
                    }
                    else
                    {
                        nomes[i] = nome_aux;
                        errado = false;
                    }
                } while (errado);

                do
                {
                    Console.Write("Sua idade: ");
                    idade_aux = int.Parse(Console.ReadLine());

                    if (idade_aux > 80 || idade_aux < 0)
                    {
                        Console.WriteLine("A idade precisa estar entre 0 e 80");
                        errado = true;
                    }
                    else
                    {

                        idades[i] = idade_aux;
                        errado = false;

                        if (idade_aux > maior_idade)
                        {
                            maior_idade = idade_aux;
                            index_maior_idade = i;
                        }
                    }
                } while (errado);
            }

            Console.WriteLine($"A pessoa mais velha tem {maior_idade} anos. Seu nome é \"{nomes[index_maior_idade]}\"");
        }
    }
}
