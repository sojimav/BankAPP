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
            
            Console.WriteLine("Welcome to Mavics Bank\n");
            Console.Write("Press 1 to Create Account or 2 to Login: ");
            collectInput = Console.ReadLine();

            if (collectInput == "1")
            {
                CreateAccount.CreateCustomerAccount();

            }
            if (collectInput == "2")
            {
                Login.CollectLoginDetails();
             
            }

        }

        public static void AfterAccountCreationPrompt()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Input the Corresponding digit\n\n");
            Console.ResetColor();
            Console.WriteLine(">>2: Login\n>>Q: To Quit");
        }

        public static void AfterLoginPrompt()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter the corresponding digit for your operation");
            Console.ResetColor();
            Console.Write(">>3: Deposit\n>>4: Withdrawal\n>>5: Transfer\n>>6: Check Balance\n>>7: " +
                "Get Account Statement\n>>8: Log Out\n>>9: Create Another Account\n>>Q: To Quit\n\nEnter Your Choice: ");
               collectInput =  Console.ReadLine();
        }

       
    }
}
