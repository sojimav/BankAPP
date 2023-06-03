using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAPP
{
   
    public class Login
    {
        public static string email;
        public static string password;

        public static void CollectLoginDetails()
        {
            Prompt();
            Email();
            Password();
            PromptUser.AfterLoginPrompt();
        }

        static void Prompt()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter Login details (Email and Password!)\n");
            Console.ResetColor();
        }
        static void Email()
        {
            do
            {
                Console.Write("Enter Your Email:\n");
                email = Console.ReadLine()!;

                if(email != CreateAccount._Email)
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("Invalid Email Address, Please enter the correct email address");
                    Console.ResetColor();
                }
            } 
            while(!Validation.LoginEmailValidation(email, CreateAccount._Email));
                
        }

        static void Password()
        {
            do
            {
                Console.Write("Enter Password:\n");
                password = Console.ReadLine()!;
                if(password != CreateAccount._Password)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Password, Please enter the correct password!");
                    Console.ResetColor();
                }
            }
            while(!Validation.LoginPasswordValidation(password, CreateAccount._Password));
            
        }
    }
}
