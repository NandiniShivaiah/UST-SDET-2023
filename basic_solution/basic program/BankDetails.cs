using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_program
{
    internal class BankDetails
    {
        public BankDetails(int custid, long accountNo, string? name, string? status)
        {
            Custid = custid;
            AccountNo = accountNo;
            Name = name;
            this.status = status;
        }

        
       

        public int Custid { get; set; }
       public long AccountNo { get; set; }
        public string? Name { get; set; }
        public string? status { get; set; }

        public void GetAccDetails(int custid)
        {
            if (Custid == custid)
                Console.WriteLine("Accno:{0}\t Name:{1}\t Status:{2}", AccountNo, Name, status);
            else
            {
                Console.WriteLine("Custid does mot exist");
            }
        }
        public void GetAccDetails(long accNum)
        {
            if (AccountNo == accNum)
                Console.WriteLine("CustId:{0}\t Name:{1}\t Status:{2}", Custid, Name, status);
            else
            {
                Console.WriteLine("Custid does mot exist");
            }
        }
        public void GetAccDetails(string? name)
        {
            if (Name == name)
                Console.WriteLine("CustId:{0}\t AccountNo:{1}\t Status:{2}", Custid, AccountNo, status);
            else
            {
                Console.WriteLine("Custid does mot exist");
            }
        }

        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome");
        }



    }
}
