using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Contagem
            Int16 i;

            Console.WriteLine("Contagem com for()");

            for (i=1; i<=10; i++)
            {
                Console.WriteLine($"I=>{i}");
            }

            Console.WriteLine("Contagem com do..while()");

            i = 100;

            do
            {
                Console.WriteLine($"I=>{i}");
                i++;
            } while (i <= 10);

            Console.WriteLine("Contagem com while()");

            i = 100;
            while (i <= 10)
            {
                Console.WriteLine($"I=>{i}");
                i++;
            }

            // Validando uma idade

            int idade = -1;

            while (idade < 0 || idade > 100)
            {
                Console.Write("Digite a idade (0-100): ");
                idade = int.Parse(Console.ReadLine());
            }

            Console.ReadKey();
        }
    }
}
