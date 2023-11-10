using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_program
{
    internal class TeachingStaff:StaffDetails
    {
        public string? Specializations { set; get;}
        public int Sem { set; get; }
        
        public void DisplayTSStaffDetails()
        {
            Console.WriteLine("Spec:{0}\n Sem:{1}", Specializations, Sem);
        }
    }
}
