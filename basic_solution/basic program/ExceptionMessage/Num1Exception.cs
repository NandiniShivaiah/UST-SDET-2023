using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_program.ExceptionMessage
{
    internal class Num1Exception:Exception
    {
        private static string? message;

        public Num1Exception(string? meassage):base(message)
        {
            
        }

    }
}
