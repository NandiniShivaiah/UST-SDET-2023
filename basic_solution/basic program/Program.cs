// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Enter 2 numbers");

int num1, num2, ans;

num1=Convert.ToInt32(Console.ReadLine());
num2 = Convert.ToInt32(Console.ReadLine());


ans = num1 + num2;
Console.WriteLine(ans);

string? s1="";
string? s2="";

string s3;
s1 = Console.ReadLine();
s2=Console.ReadLine();

s3 = s1 + " " + s2;
Console.WriteLine(s3);

Console.WriteLine(s1.Equals(s2));
Console.WriteLine(s1.ToUpper());
Console.WriteLine(s1.ToLower());

Console.WriteLine(s2.Substring(3));
string[] s=s3.Split(' ');
for(int i=0; i<s.Length;i++)
Console.WriteLine(s);*/

/*char x ='5';
switch (x)
{
    case '1':
        Console.WriteLine();
        break;

    case '2':
        Console.WriteLine();
        break;

    case '3':
        Console.WriteLine();
        break;

    default:Console.WriteLine();
        break;
}*/
//driver
using basic_program;
using basic_program.ExceptionMessage;
using System;
using System.Collections;


//public delegate void Del1();
public delegate void Del1(string mess);
public delegate void Del2();
public delegate int Del3();

class Program






{

    // private static  MethodA()
    /*public static void dellcall()
    {
        Del1 dobj1 = DelEx.MethodA;
    }
    public static void Main(string[] args)
    {
        dellcall();
    }*/

    public static void Main(string[] args)
    {

    }
}
   /* {
        // Del1 dobj1 = DelEx.MethodA;
        //dobj1.Invoke();
        /*DelEx delEx = new DelEx();
        Del1 dobj1 = DelEx.MethodA;
        dobj1("hello");*/

        // inheritance

        /*Del1 dobj1 = DelEx.MethodA;
        dobj1("hii");

        DelEx delEx = new();
        Del2 dobj2 = delEx.Add;
        dobj2(10, 70);




    }
}




/*static void Swap<T>(ref T num1, ref T num2)
{
    T temp;
    temp = num1;
    num1 = num2;
    num2 = temp;
}
int n1 = 10, n2 = 20;
char c1 = 'a', c2 = 'b';

Swap<int>(ref n1, ref n2);
Swap<char>(ref c1, ref c2);

Console.WriteLine("a={0},b={1}", n1, n2);
Console.WriteLine("c={0},d={1}", c1, c2);



//GenEx<int> ga=new GenEx<int>(new int[] {10,20});
//GenEx<int> ga = new GenEx<int>(new int[2] {20,60});
/*GenEx<int> ga = new (new int[] { 10, 20 });
ga.Display();*/

/*GenEx<int> g1 = new GenEx<int>(10, 20);
Console.WriteLine(g1.Val1+" "+ g1.Val2);

GenEx<double> g2 = new GenEx<double>(10.00, 20.23);
Console.WriteLine(g2.Val1 + " " + g2.Val2);

GenEx<string> g3= new GenEx<string>("hii", "hello");
Console.WriteLine(g3.Val1 + " " + g3.Val2);

GenEx<bool> g4= new GenEx<bool>(true, false);
Console.WriteLine(g4.Val1 + " " + g4.Val2);

/*FileOperations fileop = new FileOperations();
fileop.CreateFile();

fileop.WriteData();
fileop.ReadData();
fileop.CopyMoveFile();
fileop.DeleteData();
fileop.FileProperties();

/*ExcepHandling excep = new ExcepHandling(10, 0);
myExceptions myExceptions = new myExceptions();

//excep.Divide();
try {
    excep.Divide();
    
}
catch (ArithmeticException ex)
{
    //Console.WriteLine(ex.Message);
    
   Console.WriteLine(myExceptions.exmesslist["NonHun"]);
    // Console.WriteLine(ex.Source);
    //Console.WriteLine("Don't give zero for denominator");

}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine(myExceptions.exmesslist["IOR"]);
}
catch (Exception ex)
{
    Console.WriteLine(myExceptions.exmesslist["UE"]);
}
finally
{
    Console.WriteLine("Done");
}
        


//NGC ngc=new NGC();
/*ngc.ArrayListHandling();
ngc.StackHandling();
ngc.QueueHandling();
ngc.HashTablehandling();*/
/*ngc.SLHandling();*/

/*basic_program.GC gc = new();
//gc.ListHandling();
gc.StackHandling();
gc.Dicthandling();



/*BankDetails bank = new BankDetails(1234, 234567891L, "Nan","Inactive");*/
/*BankdetailsNew bank = new(123, 56788L, "BHN", "ACtive");
bank.WelcomeMessage();
Console.WriteLine("1.Custid 2.Accno 3. Name");
int ch=Convert.ToInt32(Console.ReadLine());

switch(ch)
{
    case 1:
        Console.WriteLine("Custid:");
        bank.GetAccDetails(Convert.ToInt32(Console.ReadLine()));
        break;

    case 2:
        Console.WriteLine("Accno:");
        bank.GetAccDetails(Convert.ToInt64(Console.ReadLine()));
        break;

        case 3:

        Console.WriteLine("Name:");
        bank.GetAccDetails(Console.ReadLine());
        break;
}





/*Docter docter = new Docter();
docter.AddNewDocter();
docter.DisplayDocterDetails();
docter.ModifyDocter();
docter.DisplayDocterDetails();
docter.BookApp(1234,"Jin");
/*docter.DeleteApp("Jin");*/


/*EV eV = new();
eV.VehicleNum = 9999;
eV.Brand = "TATA";
eV.Model = "2022";
eV.Display();
Console.WriteLine(eV.setTypeForVeh());

PV pV = new();
eV.VehicleNum = 7890;
eV.Brand = "SCORPIO";
eV.Model = "2012";
eV.Display();
Console.WriteLine(pV.setTypeForVeh());*/




/*Console.WriteLine("1.TS 2.NTS");
switch(Convert.ToInt32(Console.ReadLine())
    {
    case 1:
        TeachingStaff ts = new TeachingStaff();
        ts.StaffId = 111;
        ts.Name = "TS1";
        ts.Dept = "CS";
        ts.Specializations = "OS,DBMS,DS";
        ts.Sem = 4;
        ts.DisplayStaffDetails();
        ts.DisplayTSStaffDetails();
        break;

    case 2:
        NonTeachingStaff nts = new NonTeachingStaff();
        nts.StaffId = 111;
        nts.Name = "TS1";
        nts.Dept = "CS";
        nts.Specializations = "OS,DBMS,DS";
        nts.Sem = 4;
        nts.DisplayStaffDetails();
        nts.DisplayTSStaffDetails();
        break;



}*/

/*StudentMarks marks = new(100, "aa", "trv", 87, 89, 78, 56, 80);*/
/*StudentMarks marks = new();
marks.RollNo = 10000;
marks.StudentName = "aa";
marks.Mark1 = 99;
marks.Mark2 = 67;
marks.Mark3 = 99;
marks.DisplayStudentDetails();
Console.WriteLine("Total:"+marks.CalculateTotal());
Console.WriteLine("Average:"+marks.CalculateAverage());
/*Console.WriteLine("Grade:" + marks.CalculateGrade());


/*ArraysEx arraysex = new();
arraysex.Onedime();
arraysex.Ja();


arraysex.Twodim();

/*Employee employee = new(111, "AA", "IT", 10000);
Console.WriteLine("Emp id:{0}\n Name:{1}\n" + "Dept :{2}\n"+ "basicpay:{3}\n",
    employee.Eid,employee.Ename,employee.Dept,employee.Basicpay);
Console.WriteLine("Net Pay:{0}", employee.CalculateSalary());
/*Console.WriteLine(employee.Dept);
Console.WriteLine(employee.Ename);
Console.WriteLine(employee.CalculateSalary());

/*int consumernumber = Convert.ToInt32(Console.ReadLine());
Electricity electricity1 = new Electricity(consumernumber,9000,9300,"aa");
Console.WriteLine(electricity1.consumernumber);
Console.WriteLine(electricity1.consumername);
Console.WriteLine(electricity1.CalculateBill);
Electricity electricity2 = new Electricity(123456, 9000, 1000, "aa");
Console.WriteLine(electricity2.consumernumber);
Console.WriteLine(electricity2.consumername);
Console.WriteLine(electricity2.CalculateBill);

//double billamount = electricity = electricity.CalculateBill();



/*Calculation calculation = new Calculation();
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

double res = calculation.Add(num1 + num2);
Console.WriteLine(res);*/


