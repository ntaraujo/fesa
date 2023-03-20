using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercício3
{
    internal class Funcionários
    {
        private int id;
        private string nome;
        private string rg;
        private double salario;

        public int getId() => id;
        public string getNome() => nome;
        public string getRg() => rg;
        public double getSalário() => salario;

        public void setId(int id)
        {
            if (id <= 0)
            {
                throw new Exception("O id não pode ser menor ou igual a zero");
            }
            else
            {
                this.id = id;
            }

        }
        public void setNome(string nome)
        {
            if (!string.IsNullOrEmpty(nome)) 
            {
                this.nome = nome;
            }
            else 
            {
                throw new Exception("Preencha um nome");
            }
        }
        public void setRg(string rg)
        {
            if (!string.IsNullOrEmpty(rg))
            {
                this.rg = rg;
            }
            else
            {
                throw new Exception("Preencha um nome");
            }
        }
        public void setSalario(double salario)
        {
            if (salario >= 0)
            {
                this.salario = salario;
            }
            else
            {
                throw new Exception("Salário deve ser positivo ou 0");
            }
        }

        public double getInss(double salario)
        {
            return salario * 0.11;
        }
        public double calcularSalario(double salario)
        {
            return (salario - getInss(salario));
        }

    }
}
