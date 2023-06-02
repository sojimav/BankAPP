using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAPP
{

    public class AccountDetails
    {
        //public static List<AllAccounts> method = CreateAccount.allaccount;
          
        public static void Details()
        {
                  
            Console.WriteLine("....................................................................................");
            Console.WriteLine("|        FULL NAME      |  ACCOUNT NUMBER  |    ACCOUNT TYPE    |   AMOUNT TYPE    |");
            Console.WriteLine("|                       |                  |                    |                  |");
            Console.WriteLine("....................................................................................");

         
             string display = "";
            foreach (AllAccounts accounts in Program.addDetails)
            {
                display += $"{accounts.customersFullName, 10} | {accounts.AccountNumber, 10} | {accounts.AccountType, 10} | {accounts.AccountBalance, 10}\n";
                
            }

            Console.WriteLine(display);

            PromptUser.AfterLoginPrompt();
        }


        public static void DisplayBalance()
        {
            decimal balance = 0;
           Console.WriteLine("Input Account Number");
            string accountNo = Console.ReadLine(); 
            Validation.checkAccountNo(accountNo);

           var theAccountRow = Validation.CompareAccounts(accountNo);
            if(theAccountRow != null)
            {
                balance =  theAccountRow.AccountBalance;
                Console.WriteLine($"Your {theAccountRow.AccountType} account balance is {balance}");
            }

            PromptUser.AfterLoginPrompt();
        }
    }
}
