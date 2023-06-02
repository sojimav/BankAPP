using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAPP
{
    public class Withdraw
    {
        public static decimal Withdrawal { get; set; }
        private static string ActionAction = "withdraw";

        public static void WithdrawAmount()
        {
            Console.WriteLine("Input Your Account No");
            string getAccountNo = Console.ReadLine();
            Validation.checkAccountNo(getAccountNo);
            
             Withdrawal = Validation.PerformAction(ActionAction);
            var accountToUpdate = Validation.CompareAccounts(getAccountNo);

            string result = "";
       
                if (accountToUpdate != null && accountToUpdate.AccountType == "Savings")
                {
                    if(accountToUpdate.AccountBalance >= Withdrawal)
                    {
                        accountToUpdate.AccountBalance -= Withdrawal;
                        result = accountToUpdate.AccountNumber;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Insufficient Balance!");
                        Console.ResetColor();
                        PromptUser.AfterLoginPrompt();
                    }
                }
                if(accountToUpdate != null && accountToUpdate.AccountType == "Current")
                {
                    if(accountToUpdate.AccountBalance > 1000 && accountToUpdate.AccountBalance > Withdrawal)
                    {
                        accountToUpdate.AccountBalance -= Withdrawal;
                        result = accountToUpdate.AccountNumber;
                     Console.WriteLine($"Congratulations, {Withdrawal} has been Withdrawn " +
                        $"successfully from your account {result}");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Insufficient Balance! Current Account can't be below 1000");
                        PromptUser.AfterLoginPrompt();

                    }
                }
                   
            //}

            

            PromptUser.AfterLoginPrompt();
        }
    }
}
