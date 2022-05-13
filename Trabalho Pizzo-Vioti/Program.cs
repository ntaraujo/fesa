using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Pizzo_Vioti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = new int[3];
            int[] vetor2 = new int[3];
            int[] produtoVetorial = new int[3];
            float produtoEscalar;
            int calculo1, calculo2, calculo3;
            double moduloVetor1, moduloVetor2, moduloProdutoVetorial, cosseno, areaTriangulo, seno, angulo;
            char opção;

            do
            {
                do
                {
                    Console.Write("Digite o valor de X para o primeiro vetor: ");
                    vetor1[0] = int.Parse(Console.ReadLine());
                    Console.Write("Digite o valor de Y para o primeiro vetor: ");
                    vetor1[1] = int.Parse(Console.ReadLine());
                    Console.Write("Digite o valor de Z para o primeiro vetor: ");
                    vetor1[2] = int.Parse(Console.ReadLine());
                    Console.Write("Digite o valor de X para o segundo vetor: ");
                    vetor2[0] = int.Parse(Console.ReadLine());
                    Console.Write("Digite o valor de Y para o segundo vetor: ");
                    vetor2[1] = int.Parse(Console.ReadLine());
                    Console.Write("Digite o valor de Z para o segundo vetor: ");
                    vetor2[2] = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Os vetores são: Vetor 1 ({vetor1[0]},{vetor1[1]},{vetor1[2]})" +
                                                   $" e Vetor 2 ({vetor2[0]},{vetor2[1]},{vetor2[2]})");
                    Console.Write("Aperte Enter para continuar ");
                    Console.ReadLine();

                    do
                    {
                        Console.Write("Deseja mudar os vetores? Digite S para sim ou N para não: ");
                        opção = Console.ReadLine().ToLower()[0];
                        if (opção != 's' && opção != 'n')
                        {
                            Console.WriteLine("Digite uma opção válida");
                        }
                    }
                    while (opção != 's' && opção != 'n');

                }
                while (opção == 's');
                Console.Clear();

                do
                {
                    //Menu de seleção de operações
                    Console.Write("MENU:\n" +
                                  "1- Cosseno\n" +
                                  "2- Seno\n" +
                                  "3- Produto escalar\n" +
                                  "4- Ângulo entre os vetores\n" +
                                  "5- Área do triângulo\n" +
                                  "6- Área do paralelogramo" +
                                  "Qual operação você deseja fazer? "
                                  );
                    opção = Console.ReadLine().ToLower()[0];
                    Console.WriteLine();

                    //Calculos

                    //Calculo do produto escalar
                    produtoEscalar = vetor1[0] * vetor2[0] + vetor1[1] * vetor2[1] + vetor1[2] * vetor2[2];

                    //Calculo do cosseno
                    calculo1 = ((vetor1[0] * vetor1[0]) + (vetor1[1] * vetor1[1]) + (vetor1[2] * vetor1[2]));
                    moduloVetor1 = Math.Pow(calculo1, 0.5);
                    calculo2 = ((vetor2[0] * vetor2[0]) + (vetor2[1] * vetor2[1]) + (vetor2[2] * vetor2[2]));
                    moduloVetor2 = Math.Pow(calculo2, 0.5);
                    cosseno = produtoEscalar / (moduloVetor1 * moduloVetor2);

                    //Calculo da área do paralelogramo
                    produtoVetorial[0] = (vetor2[2] * vetor1[1]) - (vetor1[2] * vetor2[1]);
                    produtoVetorial[1] = (vetor1[2] * vetor2[0]) - (vetor2[2] * vetor1[0]);
                    produtoVetorial[2] = (vetor2[1] * vetor1[0]) - (vetor1[1] * vetor2[0]);
                    calculo3 = ((produtoVetorial[0] * produtoVetorial[0]) + (produtoVetorial[1] * produtoVetorial[1]) + (produtoVetorial[2] * produtoVetorial[2]));
                    moduloProdutoVetorial = Math.Pow(calculo3, 0.5);

                    //operações
                    //Cosseno
                    if (opção == '1')
                    {
                        Console.Write($"O valor do cosseno é: {cosseno}");
                    }
                    //seno
                    else if (opção == '2')
                    {
                        seno = moduloProdutoVetorial / (moduloVetor1 * moduloVetor2);

                        Console.Write($"O valor do seno é: {seno} ");
                    }
                    //Produto Escalar
                    else if (opção == '3')
                    {

                        Console.Write($"O produto escalar desses vetores é igual a: {produtoEscalar}");
                    }
                    //Ângulo entre os vetores
                    else if (opção == '4')
                    {
                        angulo = Math.Acos(cosseno) * 57.2958;

                        Console.Write($"O ângulo entre os vetores vale {angulo} graus");
                    }
                    //Área do triângulo
                    else if (opção == '5')
                    {
                        areaTriangulo = moduloProdutoVetorial / 2;

                        if (areaTriangulo == 0)
                            Console.Write("Área não existente");
                        else
                            Console.Write($"A área do triângulo é: {areaTriangulo}");
                    }
                    //Área do paralelogramo
                    else if (opção == '6')
                    {

                        if (moduloProdutoVetorial == 0)
                            Console.Write("Área não existente");
                        else
                            Console.Write($"A área do paralelogramo é: {moduloProdutoVetorial}");
                    }
                    else
                    {
                        Console.WriteLine("Selecione uma opção válida");
                    }
                }
                while (opção != '1' && opção != '2' && opção != '3' && opção != '4' && opção != '5' && opção != '6');
                Console.Clear();

                do
                {
                    Console.Write("Aperte S para sair do programa ou C para continuar: ");
                    opção = Console.ReadLine().ToLower()[0];
                    if (opção != 's' && opção != 'c')
                    {
                        Console.WriteLine("Digite uma opção válida");
                    }
                }
                while (opção != 's' && opção != 'c');
            }
            while (opção == 'c');
        }
    }
}
