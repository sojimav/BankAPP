using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAPP
{
    public class Withdraw
    {
        public static decimal Withdrawal { get ; set; }

        public static void WithdrawAmount()
        {
            Console.WriteLine("Input Your Account No");
            string getAccoutNo = Console.ReadLine();


            Console.Write("Enter amount to Withdraw:");
             Withdrawal = decimal.Parse(Console.ReadLine());

            string result = "";
            foreach (var accounts in Program.addDetails)
            {
                if (accounts.AccountNumber.Contains(getAccoutNo) && accounts.AccountType == "Savings")
                {
                    if(accounts.AccountBalance >= Withdrawal)
                    {
                        accounts.AccountBalance -= Withdrawal;
                        result = accounts.AccountNumber;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Insufficient Balance!");
                        Console.ResetColor();
                        PromptUser.AfterLoginPrompt();
                    }
                }
                if(accounts.AccountNumber.Contains(getAccoutNo) && accounts.AccountType == "Current")
                {
                    if(accounts.AccountBalance > 1000 && accounts.AccountBalance > Withdrawal)
                    {
                        accounts.AccountBalance -= Withdrawal;
                        result = accounts.AccountNumber;
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
                   
            }

            

            PromptUser.AfterLoginPrompt();
        }
    }
}
