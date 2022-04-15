using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] nomes = new string[5];

            for (Int16 ind=0; ind<nomes.Length; ind++)
            {
                Console.Write($"Digite o nome[{ind}]: ");
                nomes[ind] = Console.ReadLine();
            }
        }
    }
}
