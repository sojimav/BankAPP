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
            FullName();
            Password();
            
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
