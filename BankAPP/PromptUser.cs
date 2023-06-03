using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAPP
{
    public class PromptUser
    {
        public static void InitialPrompt()
        {
             string collectInput;
            do
            {
                Console.Clear();
                Console.WriteLine("\nWelcome to Mavics Bank\n");
                Console.Write("Press 1 to Create an Account or Q to Exit: "); 
                collectInput = Console.ReadLine()!;
                if (Validation.InitialPromptValidation(collectInput.ToUpper()))
                {
                    Selection(collectInput);
                }
                                       
            }
            while(!Validation.InitialPromptValidation(collectInput.ToUpper()));
            

        }

        public static void AfterAccountCreationPrompt()
        {
            string afterAccountCreation = "";
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Input the Corresponding digit\n");
                Console.ResetColor();
                Console.Write(">>2: Login\n>>Q: To Quit\n" +
                    "Enter Your Option: ");
                afterAccountCreation = Console.ReadLine();
                if (Validation.AfterAccPrompt(afterAccountCreation))
                {
                    Selection(afterAccountCreation);
                }   
            }
            while (!Validation.AfterAccPrompt(afterAccountCreation));
           

        }

        public static void AfterLoginPrompt()
        {
            string AfterLoginPrompt = "";
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter the corresponding value for your operation\n");
                Console.ResetColor();
                Console.Write(">>C: Create Another Account\n>>3: Deposit\n>>4: Withdrawal\n>>5: Transfer\n>>6: Check Balance\n>>7: " +
                    "Display Account Details\n>>8: Get Account Statement\n>>9: Log Out\n>>Q: To Quit\n\nEnter Your Choice: ");
                AfterLoginPrompt = Console.ReadLine().ToUpper();
                if (Validation.Prompt(AfterLoginPrompt.ToUpper()))
                {
                    Selection(AfterLoginPrompt.ToUpper());
                }
               
            }while(!Validation.Prompt(AfterLoginPrompt.ToUpper()));
           
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
                    Deposit.CollectAccountNo();
                    break;
                case "4":
                    Console.Clear();
                    Withdraw.WithdrawAmount();
                    break;
                case "5":
                    Console.Clear();
                    Transfer.TransferMoney();
                    break;
                case "6":
                    Console.Clear();
                    AccountDetails.DisplayBalance();
                    break;
                case "7":
                    Console.Clear();
                    AccountDetails.Details();
                    break;
                case "8":
                    Console.Clear();
                    Statement.GetStatment();
                    break;
                case "9":
                    Console.Clear();
                    Logout.LogOut();
                    break;
                case "C":
                    Console.Clear();
                    CreateAccount.AddMoreAccount();
                    break;
                case "Q":
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Logout.LogOut();
                    break;

            }
        }
       
    }
}
