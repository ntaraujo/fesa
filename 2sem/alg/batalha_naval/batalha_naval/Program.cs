using System;

namespace batalha_naval
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            string resposta;
            char[] tabuleiro;
            do
            {
                tabuleiro = TabuleiroAleatorio(60);
                MostraEmGrade(tabuleiro, 10);

                Console.Write("Deseja rodar de novo? (S/n) ");
                resposta = Console.ReadLine().ToUpper();

                if (resposta.Length == 1 && resposta[0] == 'N')
                {
                    continuar = false;
                }
                else
                {
                    Console.Clear();
                }

            } while (continuar);
        }

        static char[] TabuleiroAleatorio(int tamanhoTabuleiro)
        {
            // PPPPP CCCC CCCC DDD DDD DDD SS SS SS
            char[] simbolos =   { 'P', 'C', 'D', 'S' };
            int[] tamanhos =    {  5,   4,   3,   2  };
            int[] quantidades = {  1,   2,   3,   3  };

            // enche o tabuleiro de água
            char[] tabuleiro = new char[tamanhoTabuleiro];
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

            return tabuleiro;
        }

        static void MostraEmGrade(char[] cadeiaDeTexto, int colunas)
        {
            for (int i = 0; i < cadeiaDeTexto.Length; i++)
            {
                Console.Write(cadeiaDeTexto[i] + " ");

                if ((i+1) % colunas == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
