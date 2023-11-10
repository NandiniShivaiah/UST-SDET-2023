using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_program
{
    internal abstract class Vehicle
    {
        public int VehicleNum { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public string? Type { get; set; }

        public abstract string? setTypeForVeh();
        public void Display()
        {
            Console.WriteLine(VehicleNum + " ," + Brand + "," + Model + "," + Type + ",");
        }
        

    }
}
