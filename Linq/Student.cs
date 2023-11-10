using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Student
    {
        public Student(int studentId, string? studentName, string? dept)
        {
            StudentId = studentId;
            StudentName = studentName;
            Dept = dept;
        }

        public int StudentId { get; set; }
        public string? StudentName { get; set; }

        public string? Dept { get; set; }
    }
}
