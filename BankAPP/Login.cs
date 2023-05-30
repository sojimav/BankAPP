using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAPP
{
   
    public class Login
    {
        public static string fullName;
        public static string password;

        public static void CollectLoginDetails()
        {
            Prompt();
            FullName();
            Password();
            PromptUser.AfterLoginPrompt();
        }

        static void Prompt()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter Login details, Full Name and Password!");
            Console.ResetColor();
        }
        static void FullName()
        {
            Console.Write("Enter Full Name:\n");
            fullName = Console.ReadLine();
        }

        static void Password()
        {
            Console.Write("Enter Password:\n");
            password = Console.ReadLine();
        }
    }
}
