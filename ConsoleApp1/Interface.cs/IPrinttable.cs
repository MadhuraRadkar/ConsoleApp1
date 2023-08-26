using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interface.cs
{
    public interface IPrinttable
    {   // Implicit interface.
        string Print();
    }
    public class Employee : IPrinttable
    {
        public string Name { get; set; }
        public int EmpId { get; set; }
        public string Print()
        {
            return $"{Name}, {EmpId}";
        }

    }

    public class Manager : IPrinttable
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public int Age { get; set; }

        public string Print()
        {
            return $"{Name},{Salary},{Age}";
        }
    }

    public class Student : IPrinttable
    {
        public string Name { get; set; }
        public int Rollno { get; set; }
        public double Percentage { get; set; }

        public string Print()
        {
            return $"{Name}, {Rollno},{Percentage}";
        }
    }
}