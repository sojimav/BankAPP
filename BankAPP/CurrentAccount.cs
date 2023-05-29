using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAPP
{
    public class CurrentAccount
    {
        public string CurrentAccountNo { set; get; }
        public string customer;

        public CurrentAccount(string customer)
        {
            this.customer = customer;
        }

        public string CurrentAccountGenerator()
        {
            var currentAccount = new Random();
           CurrentAccountNo =  "1" + Convert.ToString(currentAccount.Next()).Substring(0, 9);

            return CurrentAccountNo;
        }


    }
}
