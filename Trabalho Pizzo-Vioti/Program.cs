using System;

namespace Trabalho_Pizzo_Vioti
{
    internal class Program
    {
        static void Main()
        {
            int[] vetor1 = new int[3];
            int[] vetor2 = new int[3];
            int[] produtoVetorial = new int[3];
            int produtoEscalar, calculo1, calculo2, calculo3;
            double moduloVetor1, moduloVetor2, moduloProdutoVetorial, cosseno;
            char opção;

            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Bem-vindo! Esse trabalho foi feito por:\n");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Kelvin,");
            System.Threading.Thread.Sleep(700);
            Console.WriteLine("Nathan,");
            System.Threading.Thread.Sleep(700);
            Console.WriteLine("e William\n");
            System.Threading.Thread.Sleep(700);
            Console.Write("Pressione qualquer tecla para começar! ");
            Console.ReadKey();

            do
            {
                do
                {
                    Console.Clear();

                    Console.Write("Digite o valor de X para o primeiro vetor: ");
                    vetor1[0] = int.Parse(Console.ReadLine());
                    Console.Write("Digite o valor de Y para o primeiro vetor: ");
                    vetor1[1] = int.Parse(Console.ReadLine());
                    Console.Write("Digite o valor de Z para o primeiro vetor: ");
                    vetor1[2] = int.Parse(Console.ReadLine());
                    Console.Clear();

                    Console.Write("Digite o valor de X para o segundo vetor: ");
                    vetor2[0] = int.Parse(Console.ReadLine());
                    Console.Write("Digite o valor de Y para o segundo vetor: ");
                    vetor2[1] = int.Parse(Console.ReadLine());
                    Console.Write("Digite o valor de Z para o segundo vetor: ");
                    vetor2[2] = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine($"Os vetores são: Vetor 1 ({vetor1[0]},{vetor1[1]},{vetor1[2]})" +
                                                   $" e Vetor 2 ({vetor2[0]},{vetor2[1]},{vetor2[2]})");

                    do
                    {
                        Console.Write("Deseja trocar os valores dos vetores? Digite S para sim ou N para não: ");
                        opção = Console.ReadLine().ToLower()[0];
                        if (opção != 's' && opção != 'n')
                        {
                            Console.Clear();
                            Console.WriteLine("Digite uma opção válida");
                        }
                    }
                    while (opção != 's' && opção != 'n');

                }
                while (opção == 's');

                do
                {
                    Console.Clear();
                    do
                    {
                        Console.Write("MENU:\n" +
                                      "1- Cosseno\n" +
                                      "2- Seno\n" +
                                      "3- Produto escalar\n" +
                                      "4- Ângulo entre os vetores\n" +
                                      "5- Área do triângulo\n" +
                                      "6- Área do paralelogramo\n\n" +
                                      "Qual operação você deseja fazer? "
                                      );
                        opção = Console.ReadLine().ToLower()[0];

                        // Cálculos Gerais

                        // do produto escalar
                        produtoEscalar = vetor1[0] * vetor2[0] + vetor1[1] * vetor2[1] + vetor1[2] * vetor2[2];

                        // do cosseno
                        calculo1 = ((vetor1[0] * vetor1[0]) + (vetor1[1] * vetor1[1]) + (vetor1[2] * vetor1[2]));
                        moduloVetor1 = Math.Pow(calculo1, 0.5);
                        calculo2 = ((vetor2[0] * vetor2[0]) + (vetor2[1] * vetor2[1]) + (vetor2[2] * vetor2[2]));
                        moduloVetor2 = Math.Pow(calculo2, 0.5);
                        cosseno = produtoEscalar / (moduloVetor1 * moduloVetor2);

                        // da área do paralelogramo
                        produtoVetorial[0] = (vetor2[2] * vetor1[1]) - (vetor1[2] * vetor2[1]);
                        produtoVetorial[1] = (vetor1[2] * vetor2[0]) - (vetor2[2] * vetor1[0]);
                        produtoVetorial[2] = (vetor2[1] * vetor1[0]) - (vetor1[1] * vetor2[0]);
                        calculo3 = ((produtoVetorial[0] * produtoVetorial[0]) + (produtoVetorial[1] * produtoVetorial[1]) + (produtoVetorial[2] * produtoVetorial[2]));
                        moduloProdutoVetorial = Math.Pow(calculo3, 0.5);

                        Console.Clear();

                        // Operações

                        // Cosseno
                        if (opção == '1')
                        {
                            Console.WriteLine($"O valor do cosseno é {cosseno}");
                        }

                        // Seno
                        else if (opção == '2')
                        {
                            double seno = moduloProdutoVetorial / (moduloVetor1 * moduloVetor2);
                            Console.WriteLine($"O valor do seno é {seno}");
                        }

                        // Produto Escalar
                        else if (opção == '3')
                        {
                            Console.WriteLine($"O produto escalar dos vetores é {produtoEscalar}");
                        }

                        // Ângulo entre os vetores
                        else if (opção == '4')
                        {
                            double angulo = Math.Acos(cosseno) * 57.2958;
                            Console.WriteLine($"O ângulo entre os vetores é de {angulo} graus");
                        }

                        // Área do triângulo
                        else if (opção == '5')
                        {
                            double areaTriangulo = moduloProdutoVetorial / 2;
                            Console.WriteLine($"A área do triângulo é {areaTriangulo}");
                        }

                        // Área do paralelogramo
                        else if (opção == '6')
                        {
                            Console.WriteLine($"A área do paralelogramo é {moduloProdutoVetorial}");
                        }

                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Digite uma opção válida");
                        }

                    }
                    while (opção != '1' && opção != '2' && opção != '3' && opção != '4' && opção != '5' && opção != '6');

                    do
                    {
                        Console.Write("Digite M para voltar ao menu, T para trocar os vetores e S para sair do programa: ");
                        opção = Console.ReadLine().ToLower()[0];
                        if (opção != 'm' && opção != 't' && opção != 's')
                        {
                            Console.Clear();
                            Console.WriteLine("Digite uma opção válida");
                        }
                    }
                    while (opção != 'm' && opção != 't' && opção != 's');

                } while (opção == 'm');  // Volta pro menu

            }
            while (opção == 't');  // Volta pra atribuição dos vetores
        }
    }
}
