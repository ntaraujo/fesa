using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _081220008_Questao_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float[,] peso_altura = new float[50, 2];

            float peso_aux, altura_aux;

            string[] nome = new string[50];
            bool errado;

            for (int i = 0; i < 50; i++)
            {
                Console.Write("Seu nome: ");
                nome[i] = Console.ReadLine();

                do
                {
                    Console.Write("Seu peso: ");
                    peso_aux = float.Parse(Console.ReadLine());

                    if (peso_aux > 80 || peso_aux < 50)
                    {
                        Console.WriteLine("O peso aceito é entre 50 e 80.");
                        errado = true;
                    }
                    else
                    {
                        peso_altura[i, 0] = peso_aux;
                        errado = false;
                    }
                } while (errado);

                do
                {
                    Console.Write("Sua altura: ");
                    altura_aux = float.Parse(Console.ReadLine());

                    if (altura_aux > 1.90 || altura_aux < 1.50)
                    {
                        Console.WriteLine("A altura aceita é entre 1,50m e 1,90m.");
                        errado = true;
                    }
                    else
                    {
                        peso_altura[i, 1] = altura_aux;
                        errado = false;
                    }
                } while (errado);
            }

            Console.WriteLine("Dados inseridos com sucesso.");
        }
    }
}
