using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionário f = new Funcionário();
            do
            {
                try
                {
                    Console.WriteLine("Digite o código: ");
                    f.setCodigo(Convert.ToInt32(Console.ReadLine()));
                }
                catch (Exception erro)
                {
                    Console.WriteLine(erro.Message);
                }
            }
            while (f.getCodigo() < 0);
            //entrada de dados pré privatização dos atributos
            Funcionário funcionário = new Funcionário();
            Console.WriteLine("Digite o código");
            funcionário.setCodigo(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Digite o nome");
            funcionário.setNome(Console.ReadLine());
            Console.WriteLine("Digite a data de nascimento");
            funcionário.setDataNascimento(Convert.ToDateTime(Console.ReadLine()));
            Console.WriteLine("Digite o cpf");
            funcionário.setCPF(Console.ReadLine());

            Console.WriteLine("\n\n Dados cadastrados\n\n");
            Console.WriteLine($"Código: {funcionário.getCodigo()} \nNome: {funcionário.getNome()} " +
                $"\nNascimento: {funcionário.getDataNascimento().ToShortDateString()}" +
                $"\nIdade: {funcionário.calculaIdade()}");
            Console.ReadKey();

        }
    }
}