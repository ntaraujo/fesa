using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;

            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            c = float.Parse(Console.ReadLine());

            Console.WriteLine($"MEDIA = {(a * 2 + b * 3 + c * 5) / 10}");

            Console.ReadKey();
        }
    }
}
