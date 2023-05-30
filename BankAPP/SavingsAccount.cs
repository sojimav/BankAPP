using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAPP
{
    public class SavingsAccount : IBalance
    {
        public static string SavingsAccountNo { set; get; }
        public static string customersFullName;
        public static string AssignedAccountNo;
        public static decimal AccountBalance;
        public static  string AccountType
        {
            get
            {
                return "Savings";
            }
        }

        DataBase dataBase = new DataBase(customersFullName, AssignedAccountNo, AccountType, AccountBalance);
        public SavingsAccount(string customer, string assignedAccountNo)
        {
            customersFullName = customer;
            AssignedAccountNo = assignedAccountNo;
        }

        public string SavingsAccountGenerator()
        {
             var savingsAccount = new Random();
             SavingsAccountNo =  "0" + Convert.ToString(savingsAccount.Next()).Substring(0, 9);

            return SavingsAccountNo;

        }

        public decimal GetBalance()
        {
            AccountBalance = Deposit.DepositAccount;
            return AccountBalance;
        }    
      
    }
}
