using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAPP
{
    public class SavingsAccount
    {
        public static string SavingsAccountNo { set; get; }
        public static string customersFullName;
        public static string AssignedAccountNo;
        public static  string AccountType
        {
            get
            {
                return "Savings";
            }
        }
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

        static void StoreDetails()
        {

           // DataBase dataBase = new DataBase(customersFullName);
        }
         
              
      
    }
}
