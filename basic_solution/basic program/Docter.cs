using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_program
{
    internal class Docter : IDocter,IAppointment
    {
        public int Did { get; set; }
        public string? DName { get; set; }
        public object? PName { get; private set; }

        public void AddNewDocter()
        {
           Did = 1234;
            DName = "Jin";
        }

        public void ModifyDocter()
        {
            Did = 678;
            DName = "RM";
           
        }
        public void DisplayDocterDetails()
        {
           

            Console.WriteLine("Did:{0}\t Name:{1}",Did,DName);
        }

        public void BookApp(int Did, string? PName)
        {
            Console.WriteLine("Bokes app for {0} wih Docter {1}", PName, Did);
        }

        public void DeleteApp(int Did, string PName)
        {
            Console.WriteLine("Bokes app for {0} wih Docter {1}", PName);
        }
    }
}
