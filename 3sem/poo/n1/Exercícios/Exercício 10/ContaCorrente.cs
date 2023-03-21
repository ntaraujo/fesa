using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10
{
    internal class CheckingAccount
    {

        public int Agency { get; set; }
        public string NumberAccount { get; set; }
        public string NameHolder { get; set; }
        public double Balance { get; set; }

        public CheckingAccount(int agency, string numberAccount, string nameHolder)
        {
            Agency = agency;
            NumberAccount = numberAccount;
            NameHolder = nameHolder;
            Balance = 0;
        }

        public void Withdraw(double value)
        {
            if (value > Balance)
            {
                throw new Exception("Balance insufficient.");
            }
            Balance -= value;
        }

        public void Deposit(double value)
        {
            if (value < 0)
            {
                throw new Exception("Value must be positive");
            }
            else
            { 
                
                Balance += value; 
            }
        }
    }
}
