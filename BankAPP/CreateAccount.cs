using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BankAPP
{
    public class CreateAccount
    {
        public static string _FirstName { get; set; } = string.Empty;
        public static string _LastName { get; set; } = string.Empty;
        public static string _Email { get; set; } = string.Empty;
        public static string _Password { get; set; } = string.Empty;
        public static string _ConfirmPassword { get; set; } = string.Empty;

        public static string readInput;
        public static string AccountType { get; set; } = string.Empty;

        public static string Snumber;

        public static string Cnumber;

        public static string FullName
        {
            get
            {
                return $"{_LastName}, {_FirstName}";
            }
        }

           public static void CreateCustomerAccount()
            {
                Prompt();
                FirstName();
                LastName();
                Email();
                Password();
                ConfirmPassword();
                SelectAccountType();
                PromptUser.AfterAccountCreationPrompt();

        }

             static void Prompt()
            {
              Console.ForegroundColor = ConsoleColor.Red;
              Console.WriteLine("\nInput the following Details to create your Account\n");
              Console.ResetColor();
            }

             static void FirstName()
            {
                   Console.Write("Enter First Name:\n");
                   _FirstName = Console.ReadLine();
            }

             static void LastName()
            {
                Console.Write("Enter Last Name:\n");
                _LastName = Console.ReadLine();
            }

            
             static void Email()
            {
                Console.Write("Enter Email Address: \n");
                _Email = Console.ReadLine();
             }


             static void Password()
            {
                Console.Write("Create Your Password:\n");
                _Password = Console.ReadLine();
            }


             static void ConfirmPassword()
            {           
                Console.Write("Confirm Your Password:\n");
                _ConfirmPassword = Console.ReadLine();
             }

        public static void SelectAccountType()
        {
            Console.Clear();
            Console.WriteLine("Please Select Account Type \n");
            Console.Write("Enter 1 for Savings Account or 2 for Current Account: ");
            readInput = Console.ReadLine();
            if(readInput == "1")
            {
                Savings();
            }
            else if(readInput == "2")
            {
                Current();
            }

            
        }

         
            static void Savings()
            {    
                AccountType = "Savings";
                SavingsAccount SaccountNo = new SavingsAccount(FullName, Snumber);
                Snumber = SaccountNo.SavingsAccountGenerator();
               Console.ForegroundColor = ConsoleColor.Green;
               Console.WriteLine($"\nCongratulations {_LastName}, a Savings account number {Snumber} has been generated for you.\n\n");
               Console.ResetColor();
        }
                
            
             static void Current()
             {
                AccountType = "Current";
                CurrentAccount CaccountNo = new CurrentAccount(FullName, Cnumber);
                Cnumber = CaccountNo.CurrentAccountGenerator();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n\nCongratulations {_LastName}, a Current account number {Cnumber} has been generated for you.\n\n");
                Console.ResetColor();
             }              
          
    }        
}
