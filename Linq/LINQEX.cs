using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class LINQEX
    {
        public void Example()
        {
            List<string> courses = new List<string>();
            courses.Add("Java Tutorial");
            courses.Add("C Tutorial");
            courses.Add("C++");
            courses.Add("DBMS");
            courses.Add("Web Tech");


            //Query syntax
            /* var result = from c in courses
                          where c.Equals("DBMS")
                          select c;
            
             
               foreach (var r in result)
            {
                Console.WriteLine(r);
            }*/




            //method syntax
            /*  var result = courses.Where(c => c.Equals("DBMS"));

              foreach (var r in result)
              {
                  Console.WriteLine(r);
              }*/


            var result = courses.Where(c => c.Contains("Tutorial"));


            foreach (var r in result)
            {
                Console.WriteLine(r);
            }



        }
        public void Example2()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(1,"RM","CS"));
            students.Add(new Student(2, "JIN", "EC"));
            students.Add(new Student(3, "JHOPE", "IS"));
            students.Add(new Student(4, "SUGA", "MECH"));
            students.Add(new Student(5, "RM", "EEE"));
            students.Add(new Student(6, "V", "CS"));
            students.Add(new Student(7, "JIMIN", "CS"));

            var stud = students.Where(s => s.StudentId == 2);
            foreach (var s in stud)
            {
                Console.WriteLine(s.StudentId+" "+s.StudentName+" "+s.Dept);
            }


           /* Student stud = (Student)students.Where(s => s.StudentId == 2);
            foreach (var s in stud)
            {
                Console.WriteLine(s.StudentId + " " + s.StudentName + " " + s.Dept);
            }*/



        }

        public void Filter()
        {
            ArrayList elements=new ArrayList();
            elements.Add(1);
            elements.Add("two");
            elements.Add(3);
            elements.Add(4);
            elements.Add("five");


            var numbers = elements.OfType<int>();
            var strings=elements.OfType<string>();

            foreach(string str in  strings)
            {
                Console.WriteLine("String:"+str);
            }
            foreach(int num in numbers)
            {
                Console.WriteLine("Integer:" + num);
            }
        }
        



        }
    }

