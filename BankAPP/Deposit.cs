using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAPP
{
    abstract class Deposit : IBalance
    {
        public static decimal DepositAccount { set; get; }
        public void DepositToAccount()
        {
            Console.WriteLine("Enter amount to Deposit");
            DepositAccount = decimal.Parse(Console.ReadLine());

        }

        public decimal GetBalance()
        {
            return DepositAccount;
        }
    }
}
