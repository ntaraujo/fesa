using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data;
            Int16 dia, mes, ano, max_dia;

            Console.Write("Digite uma data no formato DD/MM/AAAA: ");
            data = Console.ReadLine();

            dia = Int16.Parse(data.Substring(0, 2));
            mes = Int16.Parse(data.Substring(3, 2));
            ano = Int16.Parse(data.Substring(6, 4));

            if (ano < 2000 || ano > 2099)
            {
                Console.WriteLine("Ano informado inválido");
            }
            else if (mes < 1 || mes > 12)
            {
                Console.WriteLine("Mês informado inválido");
            }
            else
            {
                if (mes == 2)
                {
                    if (ano % 2 == 0)
                    {
                        max_dia = 29;
                    }
                    else
                    {
                        max_dia = 28;
                    }
                }
                else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                {
                    max_dia = 30;
                }
                else
                {
                    max_dia = 31;
                }

                if (dia < 1 || dia > max_dia)
                {
                    Console.WriteLine("Dia informado inválido");
                }
            }
            Console.ReadKey();
        }
    }
}
