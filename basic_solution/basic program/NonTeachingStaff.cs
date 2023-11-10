using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_program
{
    internal class NonTeachingStaff:StaffDetails
    {
        public string? Responsibilities { set; get; }
        public int Experience { set; get; }

        public void DisplayNTStaffDetails()
        {
            Console.WriteLine("Res : {0}\n Exp :{1}", Responsibilities ,Experience);
        }

    }
}
