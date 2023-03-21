using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            exhibition("Centralized text example");
            exhibition("Text in red", ConsoleColor.Red);
            Console.ReadKey();
        }
        public static void exhibition(string text)
        {
            int positionText = (Console.WindowWidth + text.Length) / 2;
            Console.WriteLine("{0," + positionText + "}", text);
        }

        public static void exhibition(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            exhibition(text);
            Console.ResetColor();
        }
        
    }
}
