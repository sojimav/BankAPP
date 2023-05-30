using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAPP
{
    public class CurrentAccount : IBalance
    {
        public static string CurrentAccountNo { set; get; }
        public static string customersFullName;
        public static string AssignedAccountNo;
        public static decimal AccountBalance;
        public static string AccountType
        {
            get
            {
                return "Current";
            }
        }

        DataBase dataBase = new DataBase(customersFullName, AssignedAccountNo, AccountType, AccountBalance);


        public CurrentAccount(string customer, string assignedAccountNo)
        {
            customersFullName = customer;
            AssignedAccountNo = assignedAccountNo;
        }

     
        public string CurrentAccountGenerator()
        {
            var currentAccount = new Random();
           CurrentAccountNo =  "1" + Convert.ToString(currentAccount.Next()).Substring(0, 9);

            return CurrentAccountNo;
        }

        public decimal GetBalance()
        {
            AccountBalance =  Deposit.DepositAccount;

            return AccountBalance;
        }

    }
}
