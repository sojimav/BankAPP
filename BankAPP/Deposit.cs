using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAPP
{
    public class Deposit 
    {
        public static decimal DepositAmount { set; get; }
    
        public static void CollectAccountNo()
        {
            
                Console.WriteLine("Input Your Account No");
                string getAccoutNo = Console.ReadLine();
            
                Console.Write("Amount must be 1000 or more!\nEnter amount to Deposit: ");
                DepositAmount = decimal.Parse(Console.ReadLine());
                Console.WriteLine();

                if(DepositAmount < 1000)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Input!, Amount to deposit must be 1000 or more!");
                    Console.ResetColor();
                    PromptUser.AfterLoginPrompt();
                }



            string result = "";
            foreach (var item in Program.addDetails )
            {
                if(item.AccountNumber.Contains(getAccoutNo) && DepositAmount >= 1000)
                {   
                        item.AccountBalance += DepositAmount;
                        result = item.AccountNumber;
                        Console.WriteLine($"Congratulations, {DepositAmount} has been deposited" +
                        $" successfully into your account {result}");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Account Number does not exist!");
                    Console.ResetColor();
                    PromptUser.AfterLoginPrompt();
                }
                
            }

            
            
            PromptUser.AfterLoginPrompt();
        }


       

    }
}
