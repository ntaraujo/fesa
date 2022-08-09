using System;

namespace aula15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a hora: ");

            int hora = int.Parse(Console.ReadLine());

            string mensagem = (hora > 12) ? "Bom dia!" : "Boa tarde!";

            Console.WriteLine(mensagem);

        }
    }
}
