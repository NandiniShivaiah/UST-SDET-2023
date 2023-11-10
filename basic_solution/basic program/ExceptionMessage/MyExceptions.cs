using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_program.ExceptionMessage
{
    internal class myExceptions
    {


        public int Num1;
        public int Num2;/*public static List<string> exmesslist = new List<string>()
         {
             "Don't give zero for denominator",
             "Index is out of Range",
             "Unknown exception"
     };*/

        public Dictionary<string, string> exmesslist = new Dictionary<string, string>();


        public myExceptions()
        {

            exmesslist.Add("IOR", "Index is out of range");
            exmesslist.Add("DOD", "Don't give zero for denominator");
            exmesslist.Add("UE", "  Unknown exception");

        }
    }
}

        /*public object MyExceptions { get; private set; }

        public void NumCheck()
        {
            if (Num1 >= 100)
            {
                Console.WriteLine("congrats");

            }
            else
            {
                throw new Exception(MyExceptions.exmesslist["NonHun"])

              

            }
        
            if(Num2>=200)
            {
                Console.WriteLine("congrats");
            }
            else
            {
                throw new ArgumentException(myExceptions.exmesslist["NonHun")
                
             
                }
            
            }
        }


        }*/



    


    

