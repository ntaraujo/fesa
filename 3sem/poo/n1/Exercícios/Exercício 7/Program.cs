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
            Calculadora calculadora = new Calculadora();
            int somaInteiro = calculadora.Somar(10, 20); 
            double somaDouble = calculadora.Somar(3.5, 2.5);
            double somaString = calculadora.Somar("2.5", "3.5"); 
            Console.WriteLine($"Double = {0}, int = {1}, string = {2}",somaDouble, somaInteiro, somaString);
        }
    }
}
