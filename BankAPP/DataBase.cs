using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAPP
{
    public class DataBase
    {
        public string customersFullName;
        public string AccountNumber;
        public string AccountType;
        public decimal AccountBalance;
        public DataBase(string customersFullName, string AccountNumber, string AccountType, decimal AccountBalance)
        {
            this.customersFullName = customersFullName;
            this.AccountNumber = AccountNumber;
            this.AccountType = AccountType;
            this.AccountBalance = AccountBalance;
        }
        

    }
}
