using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batalha_naval_pedroza
{
    class Program
    {
        static char[] Sea = new char[60];
        static void Main(string[] args)
        {

            for (int i = 0; i < Sea.Length; i++)
            {
                Sea[i] = 'A';
            }

            PortaAviões();
            Cruzador();
            Destroyer();
            Submarino();

            for (int j = 0; j < Sea.Length; j++)
            {
                Console.Write(Sea[j]);
            }

            Console.ReadKey();
        }

        static void PortaAviões()
        {
            char[] P = new char[5];
            char simbolo = 'P';
            int quantidade = 1;
            preenchimento(P, simbolo, quantidade);
        }
        static void Cruzador()
        {
            char[] P = new char[4];
            char simbolo = 'C';
            int quantidade = 2;
            preenchimento(P, simbolo, quantidade);
        }
        static void Destroyer()
        {
            char[] P = new char[3];
            char simbolo = 'D';
            int quantidade = 3;
            preenchimento(P, simbolo, quantidade);
        }
        static void Submarino()
        {
            char[] P = new char[2];
            char simbolo = 'S';
            int quantidade = 3;
            preenchimento(P, simbolo, quantidade);

        }
        static void preenchimento(char[] P, char simbolo, int quantidade)
        {
            int tamanho = P.Length;
            bool disponibilidade;
            Random p = new Random();

            for (int contador = 0; contador < quantidade;)
            {
                int espaço = p.Next(0, (Sea.Length - tamanho));
                disponibilidade = true;

                for (int posição = 0; posição < tamanho; posição++)
                {
                    if (Sea[espaço + posição] != 'A')
                    {
                        disponibilidade = false;
                        break;
                    }
                }

                if (disponibilidade)
                {
                    for (int posicao = 0; posicao < tamanho; posicao++)
                    {
                        Sea[espaço + posicao] = simbolo;
                    }
                    contador++;
                }
            }
        }
    }

}

