﻿using System;
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

        public void Saque(double valor)
        {
            if (valor > Saldo)
            {
                throw new Exception("Saldo insuficiente.");
            }
            Saldo -= valor;
        }

        public void Deposito(double valor)
        {
            if (valor < 0)
            {
                throw new Exception("Valor deve ser positivo");
            }
            else
            { 
                
                Saldo += valor; 
            }
        }
    }
}
