using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Aluno> alunos = new List<Aluno>();
            for (int i = 0; i < 10; i++)
            {
                Console.Clear();
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
                while (true);

                Console.WriteLine("Exibir média? S/N");
                if (Console.ReadLine().ToUpper() != "N")
                {
                    Console.WriteLine(aluno.Media);
                }
                Console.WriteLine("Continuar adicionando? S/N");
                if (Console.ReadLine().ToUpper() == "N")
                {
                    break;
                }
                alunos.Add(aluno);
            }
            for( int i = 0; i < alunos.Count; i++ )
            {
                Console.WriteLine($"Name: {0}\nN1: {1}\nN2: {2}\nMédia:{3}", alunos[i].Name, alunos[i].Nota1, alunos[i].Nota2, alunos[i].Media );
            }
            Console.ReadKey();
        }
    }
}
