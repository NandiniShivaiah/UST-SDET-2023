using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_program
{
    internal class BankdetailsNew : BankDetails
    {
        public BankdetailsNew(int custid, long accountNo, string? name, string? status) : base(custid, accountNo, name, status)
        {

        }
        public new void WelcomeMessage()
        {
            Console.WriteLine("Welcome {0}",Name);
        }
    }
}
