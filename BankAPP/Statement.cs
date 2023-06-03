using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BankAPP
{
    public class Statement
    {
        
        public static void GetStatment()
        {
            Console.WriteLine("Input Account Number");
            string accountNo = Console.ReadLine()!;
            Validation.checkAccountNo(accountNo);
            var theAccountRow = Validation.CompareAccounts(accountNo);
            Console.Clear();
            Console.WriteLine();
            string display = "";

            foreach ( var details in theAccountRow.TransactionRecords)
            {
                display += $"|{details.GetDateTime}| {details.Description}| {details.TransactionAmount}| {details.Balance}|\n";
            }

            Console.WriteLine($"Statement of account for {accountNo}");
            Console.WriteLine("............................................................................................");
            Console.WriteLine("|     Date                |         Description      |       Amount      |      Balance    |");
            Console.WriteLine("............................................................................................");
            Console.WriteLine(display);
            Console.WriteLine("............................................................................................");

            PromptUser.AfterLoginPrompt();
        }
    }
}
