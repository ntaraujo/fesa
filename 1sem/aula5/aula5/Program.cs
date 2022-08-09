using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int16 inicio, quantidade, num_alg;
            string output, new_output, algarismos;
            char last_char;

            algarismos = "0123456789";
            new_output = "";
            last_char = 'a';
            num_alg = 1;

            inicio = Convert.ToInt16(Console.ReadLine());
            quantidade = Convert.ToInt16(Console.ReadLine());

            output = $"{inicio}";
            Console.WriteLine(output);

            foreach (int i in Enumerable.Range(0,  quantidade))
            {
                foreach (char ch in output)
                {
                    if (ch == last_char)
                    {
                        num_alg++;
                    }
                    else
                    {
                        new_output = new_output + $"{num_alg}{ch}";
                        num_alg = 1;
                    }
                    last_char = ch;
                }

                last_char = 'a';
                num_alg = 0;

                foreach (char ch in algarismos)
                {
                    num_alg = (short)output.Count(f => (f == ch));

                    if (num_alg != 0)
                    {
                        new_output = new_output + $"{num_alg}{ch}";
                    }
                    
                }
                output = new_output;
                new_output = "";

                Console.WriteLine(output);
            }


            Console.ReadKey();
        }
    }
}
