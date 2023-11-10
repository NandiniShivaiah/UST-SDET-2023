using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_program
{
    internal interface IAppointment
    {
        void BookApp(int Did, string PName);
        void DeleteApp(int Did,string PName);
    }
}
