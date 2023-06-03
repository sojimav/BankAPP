using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
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
   
        public static string AccountType { get; set; } = string.Empty;

        public static string accountGenerator;

        public static decimal accountBalance;
        public static List<AllAccounts> allaccount;
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

        public static void AddMoreAccount()
        {
            SelectAccountType();
            PromptUser.AfterLoginPrompt();
        }

        static void Prompt()
            {
              Console.ForegroundColor = ConsoleColor.Red;
              Console.WriteLine("\nInput the following Details to create your Account\n");
              Console.ResetColor();
            }

             static void FirstName()
            {
            do
                {
                    
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nName must start with a Capital Letter!\n");
                    Console.ResetColor();
                    Console.Write("Enter First Name:\n");
                    _FirstName = Console.ReadLine()!;
                }
            while(!Validation.NameValidation(_FirstName));
                   
            }

             static void LastName()
            {
                do
                {
                    
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nName must start with a Capital Letter!\n");
                    Console.ResetColor();
                Console.Write("Enter Last Name:\n");
                    _LastName = Console.ReadLine()!;
                }
                while(!Validation.NameValidation(_LastName));
               
            }

            
             static void Email()
            {
                do
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nEnter a Valid Email Format!\n");
                   Console.ResetColor();   
                    _Email = Console.ReadLine()!;
                }
                while(!Validation.EmailValidation(_Email));
               
             }


             static void Password()
            {
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nPassword must be 6 character with at least 1 special charater and 1 digt!\n");
                Console.ResetColor();
                Console.Write("Create Your Password:\n");
                _Password = Console.ReadLine()!;
            }
            while (!Validation.PasswordValidation(_Password));
                
            }


             static void ConfirmPassword()
        {
                do
                {
                    Console.Write("Confirm Your Password:\n");
                    _ConfirmPassword = Console.ReadLine()!;
                }        
                while(_Password != _ConfirmPassword);
             }

        public static void SelectAccountType()
        {  
            string readInput;
            do
            {
                Console.Clear();
                Console.WriteLine("Please Select Account Type \n");
                Console.Write("Enter 1 for Savings Account or 2 for Current Account: ");
                readInput = Console.ReadLine()!;
                if (readInput == "1")
                {
                    Savings();
                }
                else if (readInput == "2")
                {
                    Current();
                }
            }
            while(readInput != "1" && readInput != "2");
        }

         
            static void Savings()
            {
               AccountGenerator();
               AccountType = "Savings";
             AllAccounts account = new AllAccounts(FullName, accountGenerator, AccountType, accountBalance);
            Program.addDetails.Add(account);
            Console.ForegroundColor = ConsoleColor.Green;
               Console.WriteLine($"\nCongratulations {_LastName}, a Savings account number {accountGenerator} has been generated for you.\n\n");
               Console.ResetColor();
               
        }
                
            
             static void Current()
             {
                 
                AccountGenerator();
                AccountType = "Current";
            AllAccounts account = new AllAccounts(FullName, accountGenerator, AccountType, accountBalance);
             Program.addDetails.Add(account);
            Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n\nCongratulations {_LastName}, a Current account number {accountGenerator} has been generated for you.\n\n");
                Console.ResetColor();
                
             }   
        
          public static string AccountGenerator()
            {
                 Random account = new Random();
                accountGenerator = account.Next(1000000000, 2000000000).ToString();
              
                  return accountGenerator;
            }
          
    }        
}
 