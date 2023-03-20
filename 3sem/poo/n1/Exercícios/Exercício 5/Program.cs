using Exercício5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            do
            {
                try
                {
                    Console.WriteLine("Digite o nome do aluno: ");
                    aluno.Name = Console.ReadLine();
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            while (true);
            do
            {
                try
                {
                    Console.WriteLine("Digite a N1: ");
                    aluno.Nota1 = double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            while (true);
            do
            {
                try
                {
                    Console.WriteLine("Digite a N2: ");
                    aluno.Nota2 = double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            while(true);

            Console.WriteLine("Exibir média? S/N");
            if (Console.ReadLine().ToUpper() == "Y")
            {
                Console.WriteLine(aluno.Media);
            }
            Console.ReadKey();




        }
    }
}
