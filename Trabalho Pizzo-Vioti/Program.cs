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
            int calculo1, calculo2, calculo3, opçãoMenu;
            double moduloVetor1, moduloVetor2, moduloProdutoVetorial, cosseno, areaTriangulo, seno, angulo;
            string seleçãoOpçãoSair, seleçãoMenu, seleçãoRefazerEntrada;
            char opçãoSair, opçãoRefazerEntrada;

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
                    Console.WriteLine($"Os vetores são: Vetor 1 ({vetor1[0]},{vetor1[1]},{vetor1[2]}) e Vetor 2: ({vetor2[0]},{vetor2[1]},{vetor2[2]})");
                    Console.WriteLine("Aperte Enter para continuar");
                    Console.ReadLine();

                    do
                    {
                        Console.WriteLine("Deseja mudar os vetores? Digite S para sim ou N para não");
                        seleçãoRefazerEntrada = Console.ReadLine().ToLower();
                        opçãoRefazerEntrada = seleçãoRefazerEntrada[0];
                        if (opçãoRefazerEntrada != 's' && opçãoRefazerEntrada != 'n')
                            Console.WriteLine("Digite uma opção válida");
                    }
                    while (opçãoRefazerEntrada != 's' && opçãoRefazerEntrada != 'n');

                }
                while (opçãoRefazerEntrada == 's');
                Console.Clear();

                do
                {
                    //Menu de seleção de operações
                    Console.WriteLine("Qual operação você deseja fazer?\n" +
                                      "1- Cosseno\n" +
                                      "2- Seno\n" +
                                      "3- Produto escalar\n" +
                                      "4- Ângulo entre os vetores\n" +
                                      "5- Área do triângulo\n" +
                                      "6- Área do paralelogramo"
                                      );
                    seleçãoMenu = Console.ReadLine().ToLower();
                    opçãoMenu = seleçãoMenu[0];

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
                    if (opçãoMenu == '1')
                    {
                        Console.Write($"\nO valor do cosseno é: {cosseno}");
                    }
                    //seno
                    if (opçãoMenu == '2')
                    {
                        seno = moduloProdutoVetorial / (moduloVetor1 * moduloVetor2);

                        Console.Write($"\nO valor do seno é: {seno} ");
                    }
                    //Produto Escalar
                    if (opçãoMenu == '3')
                    {

                        Console.Write($"\nO produto escalar desses vetores é igual a: {produtoEscalar}");
                    }
                    //Ângulo entre os vetores
                    if (opçãoMenu == '4')
                    {
                        angulo = Math.Acos(cosseno) * 57.2958;

                        Console.Write($"\nO ângulo entre os vetores vale {angulo} graus");
                    }
                    //Área do triângulo
                    if (opçãoMenu == '5')
                    {
                        areaTriangulo = moduloProdutoVetorial / 2;

                        if (areaTriangulo == 0)
                            Console.Write("Área não existente");
                        else
                            Console.Write($"\nA área do triângulo é: {areaTriangulo}");
                    }
                    //Área do paralelogramo
                    else if (opçãoMenu == '6')
                    {

                        if (moduloProdutoVetorial == 0)
                            Console.Write("Área não existente");
                        else
                            Console.Write($"\nA área do paralelogramo é: {moduloProdutoVetorial}");
                    }
                    else
                        Console.WriteLine("Selecione uma opção válida");
                }
                while (opçãoMenu != '1' && opçãoMenu != '2' && opçãoMenu != '3' && opçãoMenu != '4' && opçãoMenu != '5' && opçãoMenu != '6');
                Console.Clear();

                do
                {
                    Console.WriteLine("Aperte S para sair do programa ou C para continuar");
                    seleçãoOpçãoSair = Console.ReadLine().ToLower();
                    opçãoSair = seleçãoOpçãoSair[0];
                    if (opçãoSair != 's' && opçãoSair != 'c')
                        Console.WriteLine("Digite uma opção válida");
                }
                while (opçãoSair != 's' && opçãoSair != 'c');
            }
            while (opçãoSair == 'c');
        }
    }
}
