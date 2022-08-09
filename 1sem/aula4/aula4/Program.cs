using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String frase;
            char letra;

            Console.Write("Digite uma frase qualquer: ");
            frase = Console.ReadLine();

            Console.Write("Digite uma letra qualquer: ");
            letra = Console.ReadLine()[0];

            if (letra == 'S' || letra == 's')
            {
                Console.WriteLine("Foi escolhido o SIM");
            }
            else
            {
                Console.WriteLine("Não foi escolhido o SIM");
            }

            Console.WriteLine("A frase tem {0} caracteres", frase.Length);
            Console.WriteLine("A primeira letra da frase é {0}", frase[0]);
            Console.WriteLine("A última letra da frase é: {0}", frase[frase.Length - 1]);

            String sub;

            if (frase.Length < 3)
            {
                Console.WriteLine("Frase precisa ter mais que 3 letras");
            }
            else
            {
                sub = frase.Substring(0, 3);
                Console.WriteLine($"As 3 primeiras letras são {sub}");
            }

            // procurando caracteres

            int pos = frase.IndexOf(letra);
            if (pos == -1)
            {
                Console.WriteLine($"A letra {letra} não existe na frase {frase}");
            }
            else
            {
                Console.WriteLine($"A letra {letra} está na posição {pos}");

                // acha a segunda letra

                Console.WriteLine($"A segunda letra aparece na posição {frase.IndexOf(letra, pos+1)}");
            }

            Console.ReadKey();
        }
    }
}
