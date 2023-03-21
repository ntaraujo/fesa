using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculadora = new Calculator();
            int sumInteger = calculadora.Sum(10, 20); 
            double sumDouble = calculadora.Sum(3.5, 2.5);
            double sumString = calculadora.Sum("2.5", "3.5"); 
            Console.WriteLine($"Double = {0}, int = {1}, string = {2}",sumDouble, sumInteger, sumString);
            Console.ReadKey();
        }
    }
}
