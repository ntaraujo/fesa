using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_4
{
    internal class Funcionários
    {
        private int id;
        private string nome;
        private string rg;
        private double salario;

        public int Id
        {
            get { return id; }
            set {
                if (id <= 0)
                {
                    throw new Exception("O id não pode ser menor ou igual a zero");
                }
                else                
                {
                    id = value;
                }
            }
        }
        public string Name
        {
            get { return nome; }
            set
            {
                if (!string.IsNullOrEmpty(nome))
                {
                    nome = value;
                }
                else
                {
                    throw new Exception("Preencha um nome");
                }
            }
        }
        public string Rg
        {
            get { return rg; }
            set 
            {
                if (!string.IsNullOrEmpty(rg))
                {
                    rg = value;
                }
                else
                {
                    throw new Exception("Preencha um nome");
                }
            }
        }
        public double Salario
        {
            get { return salario; }
            set 
            {
                if (salario >= 0)
                {
                    salario = value;
                }
                else
                {
                    throw new Exception("Salário deve ser positivo ou 0");
                }
            }
        }


        public double Inss
        {
            get { return salario * 0.11; }
        }
        public double calcularSalario
        {
            get{ return (salario - Inss); }
        }
    }
}
