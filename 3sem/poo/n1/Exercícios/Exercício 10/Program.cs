using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount checkingAccount = new CheckingAccount(123, "001", "João");

            checkingAccount.Deposit(1000);

            checkingAccount.Withdraw(500);

            Console.WriteLine("Agency: " + checkingAccount.Agency);
            Console.WriteLine("Account Number: " + checkingAccount.NumberAccount);
            Console.WriteLine("Name Holder: " + checkingAccount.NameHolder);
            Console.WriteLine("Balance: " + checkingAccount.Balance);

            Console.ReadKey();
        }
    }
}
