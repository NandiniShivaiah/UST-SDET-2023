using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_program
{
    internal class StaffDetails
    {
        public int StaffId { set; get; }
        public string? Name { set; get; }

        public int Dept{ set; get; }
        public int specializations { set; get; }


        public void DisplayStaffDetails()
        {
            Console.WriteLine("Id:{0}\n Sem:{1}");
            

        }


    }
}
