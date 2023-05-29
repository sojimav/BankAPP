using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAPP
{
    public class PromptUser
    {
        
        
        public static void Main(string[] args)
        {
              string collectInput;

                Console.WriteLine("Welcome to Mavics Bank");
                Console.WriteLine("Press 1 to Create Account or 2 to Login");
                collectInput = Console.ReadLine();

                if (collectInput == "1")
                {
                    CreateAccount.CreateCustomerAccount();
                    
            }
                if (collectInput == "2")
                {
                    Login.CollectLoginDetails();
                   
                }


            Console.WriteLine();
                
            
              
             
        }
    }
}
