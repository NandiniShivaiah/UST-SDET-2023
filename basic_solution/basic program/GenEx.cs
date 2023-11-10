using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_program
{
    internal class GenEx<T> where T : Exception    //Int32Converter 
    {
       

       
    }
}


       /* private T[] arr;

        public GenEx(T[] arr)
        {
            Arr = arr;
        }

        public T[] Arr { get => arr; set => arr = value; }

        public void Display()
        {
            foreach(var item in Arr)
            {
               Console.WriteLine(item);
            }
        }

    }
}*/

        /*
        private T val1,val2;

        public GenEx(T val1, T val2)
        {
            Val1 = val1;
            Val2 = val2;
        }

        public T Val1 { get => val1; set => val1 = value; }
        public T Val2 { get => val2; set => val2 = value; }


        public T Operation()
        {
            return val1 + Val2;
        }
    }
}*/
