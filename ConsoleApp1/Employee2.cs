using ConsoleApp1.Interface.cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employee2
    {
        public int employeeid { get; set; }
        public string name { get; set; }
        public double salary { get; set; }
        public static int totalEmp = 0;
        public Employee2(int id , string name,double salary)
        {
           this. employeeid = id;
            this.name = name;
            this.salary = salary;
            totalEmp++;
        }
        public void Display()
        {
            Console.WriteLine("Employee Id:{0},Name:{1},Salary:{2}", employeeid, name, salary);
        }
        public static int TotalEmp()
        {
            return totalEmp;
        }
    }
}
