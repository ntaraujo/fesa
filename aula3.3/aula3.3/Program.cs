using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int16 dia;

            Console.Write("Qual o número do dia da semana? ");
            dia = Int16.Parse(Console.ReadLine());

            if (dia == 1)
            {
                Console.Write("Esse dia é Domingo");
            }
            else if (dia == 2)
            {
                Console.Write("Esse dia é Segunda");
            }
            else if (dia == 3)
            {
                Console.Write("Esse dia é Terça");
            }
            else if (dia == 4)
            {
                Console.Write("Esse dia é Quarta");
            }
            else if (dia == 5)
            {
                Console.Write("Esse dia é Quinta");
            }
            else if (dia == 6)
            {
                Console.Write("Esse dia é Sexta");
            }
            else
            {
                Console.Write("Esse dia é Sábado");
            }

            Console.ReadKey();
        }
    }
}