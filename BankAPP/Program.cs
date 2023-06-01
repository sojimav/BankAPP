using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAPP
{
    public class Program
    {

        public static List<AllAccounts> addDetails = new List<AllAccounts>();
             
        public static void Main(string[] args)
        {
            PromptUser.InitialPrompt();  
        }
    }
}
