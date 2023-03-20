using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10
{
    internal class ContaCorrente
    {

        public int Agencia { get; set; }
        public string NumeroConta { get; set; }
        public string NameTitular { get; set; }
        public double Saldo { get; set; }

        public ContaCorrente(int agencia, string numeroConta, string nameTitular)
        {
            Agencia = agencia;
            NumeroConta = numeroConta;
            NameTitular = nameTitular;
            Saldo = 0;
        }

        public void Saque(double value)
        {
            if (value > Saldo)
            {
                throw new Exception("Saldo insuficiente.");
            }
            Saldo -= value;
        }

        public void Deposito(double value)
        {
            if (value < 0)
            {
                throw new Exception("Valor deve ser positivo");
            }
            else
            { 
                
                Saldo += value; 
            }
        }
    }
}
