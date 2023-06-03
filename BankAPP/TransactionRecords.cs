using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAPP
{
    public class TransactionRecords
    {
       public string Description { get; set; }   
       public decimal TransactionAmount { get;set; }
       public decimal Balance { get; set; }
       public DateTime GetDateTime { get; set; }
         

    }
}
