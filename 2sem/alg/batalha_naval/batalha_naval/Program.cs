using System;
using System.Runtime.InteropServices;

namespace batalha_naval
{
    class Program
    {
        static void Main(string[] args)
        {
            // PPPPP CCCC CCCC DDD DDD DDD SS SS SS
            char[] simbolos =    {'P', 'C', 'D', 'S'};
            int[]  tamanhos =    { 5,   4,   3,   2 };
            int[]  quantidades = { 1,   2,   3,   3 };

            // enche o tabuleiro de água
            char[] tabuleiro = new char[60];
            for (int i = 0; i < tabuleiro.Length; i++)
            {
                tabuleiro[i] = '.';
            }

            Random aleatorio = new Random();
            int posicao_aleatoria, tamanho_esperado;
            bool tamanho_esperado_disponivel;

            for (int i = 0, contador = 0; i < 4;)
            {
                tamanho_esperado = tamanhos[i];

                // posição aleatória entre o começo do tabuleiro e a posição máxima possível
                posicao_aleatoria = aleatorio.Next(tabuleiro.Length - 1 - tamanho_esperado);
                // a posição máxima possível pra posicionar a embarcação é o tamanho do tabuleiro menos o tamanho da embarcação

                // é tudo água onde eu quero colocar a embarcação?
                tamanho_esperado_disponivel = true;
                for (int i_posicao = 0; i_posicao < tamanho_esperado; i_posicao++)
                {
                    if (tabuleiro[posicao_aleatoria + i_posicao] != '.')
                    {
                        tamanho_esperado_disponivel = false;
                        break;
                    }
                }

                // se sim, tira a água do tabuleiro e coloca a embarcação
                if (tamanho_esperado_disponivel)
                {
                    for (int i_posicao = 0; i_posicao < tamanho_esperado; i_posicao++)
                    {
                        tabuleiro[posicao_aleatoria + i_posicao] = simbolos[i];
                    }
                    // informa que uma das X embarcações desse tipo foi posicionada
                    contador++;
                }

                // se todas as embarcações desse tipo foram posicionadas
                if (contador == quantidades[i])
                {
                    // passa para o próximo tipo
                    i++;
                    contador = 0;
                }
            }

            MostraTabuleiro(tabuleiro);
        }

        static void MostraTabuleiro(char[] tabuleiro)
        {
            // se no Windows
            if (System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                Console.WindowHeight = 10;
                Console.WindowWidth = 35;
            }

            for (int i = 0; i < tabuleiro.Length; i++)
            {
                Console.Write(tabuleiro[i] + " ");

                if (i % 10 == 9)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
