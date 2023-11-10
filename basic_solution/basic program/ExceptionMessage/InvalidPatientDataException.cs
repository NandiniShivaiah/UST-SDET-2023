using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace basic_program.ExceptionMessage
{
    internal class InvalidPatientDataException
    {
        public InvalidPatientDataException(string? patientName, int patientId, string? diagnosis, int age)
        {
            PatientName = patientName;
            PatientId = patientId;
            Diagnosis = diagnosis;
            Age = age;
        }

        public string? PatientName { get; set; }
        public int PatientId { get; set; }

        public string? Diagnosis { get; set; }

        public int Age { get; set; }

        public void CheckData()
        {
            if(PatientName!=null && PatientId!=null )
            {
                Console.WriteLine("Valid Data");
            }
            else
            {
                Console.WriteLine("Invalid Data");
            }
        }
    }
}
