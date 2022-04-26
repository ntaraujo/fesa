using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double[] valores = new double[100];
            string resposta;
            int tamanho = 100;

            for (int i = 0; i < 100; i++)
            {
                Console.Write("Digite um valor: ");
                valores[i] = Double.Parse(Console.ReadLine());
                do
                {
                    Console.Write("Deseja continuar? (s/n) ");
                    resposta = Console.ReadLine().ToLower();
                } while (resposta != "s" && resposta != "n");

                if (resposta == "n")
                {
                    tamanho = i + 1;
                    break;
                }
            }

            do
            {
                Console.Write("\nMENU:\n\n" +
                "1 - Exibir a soma dos valores lidos\n" +
                "2 - Exibir a média dos valores lidos\n" +
                "3 - Exibir o maior valor lido\n" +
                "4 - Exibir todos os valores lidos\n" +
                "5 - Sair\n\n" +
                "Sua opção: ");
                resposta = Console.ReadLine();
            } while (resposta != "1" && resposta != "2" && resposta != "3" && resposta != "4" && resposta != "5");

            if (resposta == "1")
            {
                Double soma = 0;
                for (int i = 0; i < tamanho; i++)
                {
                    soma += valores[i];
                }
                Console.WriteLine($"A soma dos valores é {soma}");
            }
            else if (resposta == "2")
            {
                Double soma = 0;
                for (int i = 0; i < tamanho; i++)
                {
                    soma += valores[i];
                }
                Console.WriteLine($"A média dos valores é {soma/tamanho}");
            }
            else if (resposta == "3")
            {
                double maior_valor = valores[0];
                for (int i = 1; i < tamanho; i++)
                {
                    if (valores[i] > maior_valor)
                    {
                        maior_valor = valores[i];
                    }
                }
                Console.WriteLine($"O maior valor é {maior_valor}");
            }
            else if (resposta == "4")
            {
                string texto = "";
                for (int i = 0; i < tamanho; i++)
                {
                    texto += $"{i+1}º valor - {valores[i]}\n";
                }
                Console.Write(texto);
            }
            
            if (resposta != "5")
            {
                Console.WriteLine();
                Main(new string[0]);
            }
        }
    }
}
