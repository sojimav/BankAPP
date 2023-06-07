using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using ConsoleTables;

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
            //string display = "";


            var table = new ConsoleTable("Date", "Description", "Amount", "Balance");
            foreach ( var details in theAccountRow.TransactionRecords)
            {
                //display += $"|{details.GetDateTime}| {details.Description}| {details.TransactionAmount}| {details.Balance}|\n";
                
                table.AddRow(details.GetDateTime, details.Description, details.TransactionAmount, details.Balance);
            }
            Console.WriteLine(table);

            //Console.WriteLine($"Statement of account for {accountNo}");
            //Console.WriteLine("............................................................................................");
            //Console.WriteLine("|     Date                |         Description      |       Amount      |      Balance     |");
            //Console.WriteLine("--------------------------------------------------------------------------------------------|");
            //Console.WriteLine(display );
            //Console.WriteLine("--------------------------------------------------------------------------------------------|");

            PromptUser.AfterLoginPrompt();
        }
    }
}
