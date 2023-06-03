using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAPP
{
    public class AllAccounts
    {
        public string customersFullName;
        public string AccountNumber;
        public string AccountType;
        public  decimal AccountBalance; 
        public List<TransactionRecords> TransactionRecords;
        public AllAccounts(string customersFullName, string AccountNumber, string AccountType, decimal accountBalance)
        {
            this.customersFullName = customersFullName;
            this.AccountNumber = AccountNumber;
            this.AccountType = AccountType;
            AccountBalance = accountBalance;
            this.TransactionRecords = new List<TransactionRecords>();
        }
         

    }
}
