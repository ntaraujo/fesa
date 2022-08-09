using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] nomes = new string[5];
            float[] salarios = new float[5];

            for (Int16 ind = 0; ind < 5; ind++)
            {
                Console.Write($"{ind+1}. Digite o nome: ");
                nomes[ind] = Console.ReadLine();
                Console.Write($"{ind+1}. Digite o salário: ");
                salarios[ind] = float.Parse(Console.ReadLine());
            }

            Console.WriteLine("---------------------");

            for (Int16 ind = 0; ind < 5; ind++)
            {
                Console.WriteLine($"{nomes[ind]} - {salarios[ind]}");
            }
        }
    }
}
