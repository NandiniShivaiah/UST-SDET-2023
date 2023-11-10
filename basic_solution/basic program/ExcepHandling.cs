using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace basic_program
{
    internal class ExcepHandling
    {
        public ExcepHandling(int num1, int num2)
        {
            Num1 = num1;
            Num2 = num2;
        }

        public int Num1 { get; set; }
        public int Num2 { get; set; }

        public void Divide()
        {
            // try

            int[] num = { 10, 20, 30 };
            // int res = Num1 / Num2;
            // Console.WriteLine(res);


            //foreach (int n in num)
            for (int i = 0; i <= 3; i++)
            {
                int res = num[i] / Num2;
                Console.WriteLine(res);


            }
        }
    }
}
        
            
           
           /* catch (ArithmeticException ex)
            {
                //Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
               // Console.WriteLine(ex.Source);
                Console.WriteLine("Don't give zero for denominator");

            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Done");
            }
        }
    }
}
*/