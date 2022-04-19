using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte[] ascii = Encoding.ASCII.GetBytes("A");
            Console.WriteLine(ascii[0]);

            Console.WriteLine(char.ConvertFromUtf32(65));

            char x = 'A';
            Console.WriteLine((byte)x);

            int y = 66;
            Console.WriteLine((char)y);

            for (int carac = 32; carac <= 126; carac++)
            {
                Console.Write($"{(char)carac}-");
            }
        }
    }
}
