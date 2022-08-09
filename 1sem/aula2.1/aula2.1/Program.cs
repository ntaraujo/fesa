using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float valorFIPE, valorCarro;

            Console.Write("Veículo: BMW X1 - 2022\n");

            Console.Write("Valor na tabela FIPE: ");
            valorFIPE = float.Parse(Console.ReadLine());

            Console.Write("Quanto você está pedindo? ");
            valorCarro = float.Parse(Console.ReadLine());

            if (valorCarro >= valorFIPE)
            {
                Console.Write($"Seu carro está acima da tabela FIPE em {(valorCarro*100/valorFIPE)-100}%");
            }
            else
            {
                Console.Write("Seu carro está com valor ABAIXO da FIPE");
            }

            Console.ReadKey();
        }
    }
}
