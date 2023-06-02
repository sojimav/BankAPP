using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BankAPP
{
    public class Validation
    {

        public static bool InitialPromptValidation(string userInput)
        { 
            bool IsValid = false;
            if (!string.IsNullOrWhiteSpace(userInput))
            {
                if(userInput == "1" || userInput == "Q")
                {
                    IsValid = true;
                }
            }

            return IsValid;
        }

        public static bool NameValidation(string name)
        {
            bool isValid = false;
            Regex checkName = new Regex("^[A-Z][a-zA-Z]*$");
            if(checkName.IsMatch(name))
            {
                isValid = true;
            }

            return isValid;
        }

        public static bool EmailValidation(string email)
        {
            bool isValid = false;
            Regex checkEmail = new Regex("^[a-zA-Z0-9.!#$%&’*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\\.[a-zA-Z0-9-]+)*$");
            if (checkEmail.IsMatch(email))
            {
                isValid = true;
            }

            return isValid;
        }

        public static bool PasswordValidation(string password)
        {
            bool isValid = false;
            Regex passwordValidation = new Regex("^(?=.*[a-zA-Z])(?=.*\\d)(?=.*[!@#$%^&*])[a-zA-Z\\d!@#$%^&*]{6,}$");
            if (passwordValidation.IsMatch(password))
            {
                isValid = true;
            }

            return isValid;
        }


        // ...............................................................................................................
        // .................................LOGIN DETAILS VALIDATION CHECK................................................
        //................................................................................................................


        public static bool LoginEmailValidation(string fromCreate, string fromLogin)
        {
            bool isValid = false;

            if(fromCreate == fromLogin)
            {
                isValid = true;
            }

            return isValid;
        }


        public static bool LoginPasswordValidation(string passwordFromCreate, string passwordFromLogin)
        {
            bool isValid = false;
            if(passwordFromCreate == passwordFromLogin)
            {
                isValid = true;
            }

            return isValid;
        }

       public static bool Prompt(string value)
        {
            bool isValid = false;
            switch (value)
            {
                case "3": case "4": case "5": case "6":
                case "7": case "8":  case "9": case "C": case "Q":
                isValid = true;
                break;
            }

            return isValid;
        }

        public static bool AfterAccPrompt(string value)
        {
            bool isValid = false;

             if(value == "2" || value == "Q")
            {
                isValid = true;
            } 

            return isValid;

        }

        // ........................................................................................................
        // .....................................Account Validations................................................
        // ........................................................................................................
        // ........................................................................................................
        public static void checkAccountNo(string accountNo)
        {
            if (String.IsNullOrWhiteSpace(accountNo) || accountNo.Length < 10)
            if(CompareAccounts(accountNo) == null) 
             { 
                Console.WriteLine("Invalid Input, Account numner does not exist!");
                PromptUser.AfterLoginPrompt();
            }
        }

        public static decimal PerformAction(string action)
        {
            string checker;
            decimal validAmount = 0;
            do
            {
                Console.Clear();
                Console.Write($"Enter amount to {action} or D for DashBoard: ");
                checker = Console.ReadLine()!;

                if (checker == "D".ToLower())
                {
                    PromptUser.AfterLoginPrompt();
                }
            } 
            while (!decimal.TryParse(checker, out validAmount));

            return validAmount;

        }

   
        public static AllAccounts CompareAccounts(string AccountNo)
        {
            var collectAllRows = Program.addDetails.FirstOrDefault(row => row.AccountNumber == AccountNo);

            return collectAllRows;
        }
    }
    
}
