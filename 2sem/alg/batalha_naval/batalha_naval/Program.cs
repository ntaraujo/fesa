using System;

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
            for (int i = 0; i < 60; i++)
            {
                tabuleiro[i] = 'A';
            }

            Random aleatorio = new Random();
            int posicao_aleatoria, tamanho_esperado;
            bool tamanho_esperado_disponivel;

            for (int i = 0, contador = 0; i < 4;)
            {
                tamanho_esperado = tamanhos[i];

                // posição máxima pra posicionar é o tamanho do tabuleiro menos o da embarcação
                posicao_aleatoria = aleatorio.Next(59-tamanho_esperado);

                tamanho_esperado_disponivel = true;
                for (int i_posicao = 0; i_posicao < tamanho_esperado; i_posicao++)
                {
                    // é tudo água onde eu quero colocar a embarcação?
                    if (tabuleiro[posicao_aleatoria + i_posicao] != 'A')
                    {
                        tamanho_esperado_disponivel = false;
                        break;
                    }
                }

                if (tamanho_esperado_disponivel)
                {
                    for (int i_posicao = 0; i_posicao < tamanho_esperado; i_posicao++)
                    {
                        tabuleiro[posicao_aleatoria + i_posicao] = simbolos[i];
                    }
                    contador++;
                }

                if (contador == quantidades[i])
                {
                    i++;
                    contador = 0;
                }
            }

            Console.WriteLine(tabuleiro);
        }
    }
}
