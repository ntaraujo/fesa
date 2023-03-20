using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_7
{
    internal class Calculadora
    {

        public int Somar(int a, int b)
        {
            return a + b;
        }

        public double Somar(double a, double b)
        {
            return a + b;
        }

        public double Somar(string a, string b)
        {
            double valorA, valorB;

            if (double.TryParse(a, out valorA) && double.TryParse(b, out valorB))
            {
                return valorA + valorB;
            }
            else
            {
                throw new Exception("Os valores informados devem ser numéricos.");
            }
        }
    }
}
