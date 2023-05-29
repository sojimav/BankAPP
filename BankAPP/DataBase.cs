using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAPP
{
    public class DataBase
    {
        public List<string> customerDetails;
        public DataBase(List<string> customerDetails)
        {
            this.customerDetails = customerDetails;
        }
        public Dictionary<string, List<string>> StoreDetails()
        {

        }
    }
}
