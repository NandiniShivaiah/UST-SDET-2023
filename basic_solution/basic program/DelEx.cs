using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_program
{
    internal class DelEx
    {
/*public void Add(int num1, int num2)
        {
            Num1 = num1;
            Num2 = num2;
        }*/
      

        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public void Add(int num1,int num2)
        {
            Num1 = num1;
            Num2 = num2;

            Console.WriteLine(Num1 + Num2);
        }
        public static void MethodA(string mess)
        {
            Console.Write(mess);
        }

        internal void Add()
        {
            throw new NotImplementedException();
        }

        /* public static void MethodA()
 {
     Console.WriteLine();
 }*/
    }
}
