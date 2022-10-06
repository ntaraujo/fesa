using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace aula20
{
    class Program
    {
        static void Main(string[] args)
        {
            Filme filme1 = new Filme();
            Filme filme2 = new Filme();

            Ator ator1 = new Ator();
            ator1.setNome("ator1");
            Ator ator2 = new Ator();
            ator2.setNome("ator2");

            filme1.addAtor(ator1);
            filme2.addAtor(ator2);

            List<Ator> lista1 = filme1.getAtores();
            List<Ator> lista2 = filme2.getAtores();

            foreach (Ator a in lista1)
            {
                Console.WriteLine(a.getNome());
            }
            foreach (Ator a in lista2)
            {
                Console.WriteLine(a.getNome());
            }
        }
    }
}
