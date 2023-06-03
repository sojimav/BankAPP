using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BankAPP
{
    public class Deposit 
    {
        public static decimal DepositAmount { set; get; }
        
        private static string AccountAction = "deposit";
  
        public static void CollectAccountNo()
        {
             string getAccoutNo;
            Console.WriteLine("Input Your Account No");
            getAccoutNo = Console.ReadLine()!;
            Validation.checkAccountNo(getAccoutNo);

            DepositAmount = Validation.PerformAction(AccountAction);
            Console.WriteLine();

                if(DepositAmount < 1000)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Input!, Amount to deposit must be 1000 or more!");
                    Console.ResetColor();
                    PromptUser.AfterLoginPrompt();
                }

            var accountsToUpdate = Validation.CompareAccounts(getAccoutNo); 
            /*Program.addDetails.FirstOrDefault( row=> row.AccountNumber == getAccoutNo)*/;

            string result = "";
                if (accountsToUpdate != null)
                {   
                        accountsToUpdate.AccountBalance += DepositAmount;
                        result = accountsToUpdate.AccountNumber;
                        Console.WriteLine($"Congratulations, {DepositAmount} has been deposited" +
                        $" successfully into your account {result}");
                       accountsToUpdate.TransactionRecords.Add(new TransactionRecords
                {
                    GetDateTime = DateTime.Now,
                    Description = "Deposit",
                    TransactionAmount = DepositAmount,
                    Balance = accountsToUpdate.AccountBalance,
                });
                        
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Account Number does not exist!");
                    Console.ResetColor();
                    PromptUser.AfterLoginPrompt();
                }
                            
            PromptUser.AfterLoginPrompt();
        }


       

    }
}
