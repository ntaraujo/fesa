using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b;

            b = a++;
            Console.WriteLine($"A = {a}\nB = {b}");

            Console.ReadKey();
        }
    }
}
