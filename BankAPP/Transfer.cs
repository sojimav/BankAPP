using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAPP
{
    public class Transfer
    {
        public static decimal TransferAmount { set; get; }
        private static string actionType = "Transfer";
        public static void TransferMoney()
        {
            string recipentAccount;
            string sendersAccount = "";
            decimal amountToTransfer;
      
            Console.WriteLine("Enter Sender's Account No");
            sendersAccount = Console.ReadLine()!;
            Validation.checkAccountNo(sendersAccount);
            Console.WriteLine("Enter Recpient's Account Number");
            recipentAccount = Console.ReadLine()!;
            Validation.checkAccountNo(recipentAccount);
           amountToTransfer = Validation.PerformAction(actionType);
            var account1 = Validation.CompareAccounts(sendersAccount);
            var account2 = Validation.CompareAccounts(recipentAccount);


            if (account1.AccountType == "Current" && (account1.AccountBalance - amountToTransfer) < 1000)
            {
                Console.WriteLine("\u001b[31m Insufficient Balance, Current Account can't be below 1000!.\u001b[0m");
                PromptUser.AfterLoginPrompt();
            }
                if (amountToTransfer < account1.AccountBalance && amountToTransfer > 0)
            {
                account1.AccountBalance -= amountToTransfer;
                account2.AccountBalance += amountToTransfer;
                Console.WriteLine($"{amountToTransfer} has been sent to {account2.AccountType} account no {account2.AccountNumber}");
                account1.TransactionRecords.Add(new TransactionRecords
                {
                    GetDateTime = DateTime.Now,
                    Description = $"Sent to {account2.AccountNumber}",
                    TransactionAmount = amountToTransfer,
                    Balance = account1.AccountBalance,
                });

                account2.TransactionRecords.Add(new TransactionRecords
                {
                    GetDateTime = DateTime.Now,
                    Description = $"Received from {account1.AccountNumber}",
                    TransactionAmount = amountToTransfer,
                    Balance = account1.AccountBalance,
                });
            }
            else
            {
              
               Console.WriteLine("\u001b[31m Insufficient Balance!.\u001b[0m");
            }
            PromptUser.AfterLoginPrompt();
        }
    }
}
