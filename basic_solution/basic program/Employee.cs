﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_program
{
    internal class Employee
    {
        private int eid;
        private string? ename, dept;
        private double basicpay;
       


        public Employee(int eid, string? ename, string? dept, double basicpay)
        {
            Eid = eid;
           Ename = ename;
           Dept = dept;
            Basicpay = basicpay;
        }

        public int Eid { get => eid; set => eid = value; }
        public string? Ename { get => ename; set => ename = value; }
        public string? Dept { get => dept; set => dept = value; }
        public double Basicpay { get => basicpay; set => basicpay = value; }

      

        public double CalculateSalary()
        {
            double grosssalary, netsalary;
            double allowances = Basicpay * 0.3 + Basicpay * 0.2 + Basicpay * 0.15;
            grosssalary =Basicpay + allowances;
            double deductions =Basicpay * 0.1;
            netsalary = grosssalary - deductions;
            return netsalary;
        }
    }
}
