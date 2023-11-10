using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace basic_program
{
    internal class FileOperations
    {

        public void CreateFile()
        {
            FileInfo fi = new("C:\\Users\\Administrator\\Desktop\\File\\Sample.txt");

            using StreamWriter str = fi.CreateText();
            Console.WriteLine("File has been created");
            str.WriteLine("hello there");
            str.WriteLine(("hii"));
            Console.WriteLine("Written");
        }

        public void WriteData()
        {
            FileStream fs = new FileStream("Sample2.txt", FileMode.Create,FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            Console.WriteLine("Enter the text" + "write in the file");
            string? str = Console.ReadLine();
            sw.WriteLine(str);
            sw.Flush();
            sw.Close();
            sw.Close();


            
        }

        public void ReadData()
        {
            FileStream fs = new FileStream("C:\\Users\\Administrator\\Desktop\\File\\Sample.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs); 
            sr.BaseStream.Seek(0,SeekOrigin.Begin);
            string str = sr.ReadLine();
            while(str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }

        public void CopyMoveFile()
        {
            FileInfo fi1 = new FileInfo("C:\\Users\\Administrator\\Desktop\\File\\Sample.txt");
            FileInfo fil2 = new FileInfo("C:\\Users\\Administrator\\Desktop\\File\\Sample2.txt");
            fi1.CopyTo("C:\\Users\\Administrator\\Desktop\\File\\Temp1" + "Sample.txt");
            fil2.MoveTo("C:\\Users\\Administrator\\Desktop\\File\\Temp2" + "sample2.txt");
        }

        public void DeleteData()
        {
            FileInfo fi = new FileInfo("C:\\Users\\Administrator\\Desktop\\File\\Temp1\\Sample.txt");
            fi.Delete();
        }
        
        public void FileProperties()
        {
            FileInfo fi = new FileInfo("C:\\Users\\Administrator\\Desktop\\File\\" + "Sample.txt");
            Console.WriteLine(fi.Name);
            Console.WriteLine(fi.CreationTime);
            Console.WriteLine(fi.LastWriteTime);
            Console.WriteLine(fi.LastAccessTime);
            Console.WriteLine(fi.Length.ToString());
            Console.WriteLine(fi.Extension);
            
        }

    }
}
