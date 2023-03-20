using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_6
{
    internal class Aluno
    {
        private string nome;
        private double nota1;
        private double nota2;

        public string Nome
        {
            get { return nome; }
            set
            {
                if (value.Trim().Split().Length < 2)
                {
                    throw new ArgumentException("O nome deve conter nome e sobrenome.");
                }
                nome = value;
            }
        }

        public double Nota1
        {
            get { return nota1; }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("A nota deve estar entre 0 e 10.");
                }
                nota1 = value;
            }
        }

        public double Nota2
        {
            get { return nota2; }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("A nota deve estar entre 0 e 10.");
                }
                nota2 = value;
            }
        }

        public double Media
        {
            get { return (nota1 + nota2) / 2; }
        }
    }
}
