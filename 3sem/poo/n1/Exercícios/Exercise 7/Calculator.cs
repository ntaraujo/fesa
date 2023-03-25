using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    internal class Calculator
    {

        public int Sum(int a, int b)
        {
            return a + b;
        }

        public double Sum(double a, double b)
        {
            return a + b;
        }

        public double Sum(string a, string b)
        {
            double valueA, valueB;

            if (double.TryParse(a, out valueA) && double.TryParse(b, out valueB))
            {
                return valueA + valueB;
            }
            else
            {
                throw new Exception("The informed values must be numbers.");
            }
        }
    }
}
