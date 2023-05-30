using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAPP
{
    public class PromptUser
    {
          public static string collectInput;
        public static void InitialPrompt()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Mavics Bank\n");
            Console.Write("Press 1 to Create Account or 2 to Login: ");
            collectInput = Console.ReadLine();
            Selection(collectInput);

        }

        public static void AfterAccountCreationPrompt()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Input the Corresponding digit\n");
            Console.ResetColor();
            Console.Write(">>1: Create Another Account\n>>2: Login\n>>Q: To Quit\n" +
                "Enter Your Option: ");
            collectInput = Console.ReadLine();
            Selection(collectInput);

        }

       

        public static void AfterLoginPrompt()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter the corresponding digit for your operation\n");
            Console.ResetColor();
            Console.Write(">>3: Deposit\n>>4: Withdrawal\n>>5: Transfer\n>>6: Check Balance\n>>7: " +
                "Get Account Statement\n>>8: Log Out\n>>1: Create Another Account\n>>Q: To Quit\n\nEnter Your Choice: ");
               collectInput =  Console.ReadLine();

            Selection(collectInput);
        }

        static void Selection(string param)
        {
            switch (param)
            {
                case "1":
                    Console.Clear();
                    CreateAccount.CreateCustomerAccount();
                    break;
                case "2":
                    Console.Clear();
                    Login.CollectLoginDetails();
                    break;
                case "3":
                    Console.Clear();
                    Deposit.DepositToAccount();
                    break;
                case "4":
                    Console.Clear();
                    Withdraw.WithdrawAmount();
                    break;
                case "5":
                    Console.Clear();
                    Transfer.Transferred();
                    break;
                case "6":
                    Console.Clear();
                    AllAccounts.ShowBalance();
                    break;
                case "7":
                    Console.Clear();
                    Statement.GetStatment();
                    break;
                default:
                    Console.Clear();
                    Logout.LogOut();
                    break;

            }
        }
       
    }
}
