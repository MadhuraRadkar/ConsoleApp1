using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employee
    {
        // create employee class with id,name,salary,department accept the data & display employee details.
        protected int ID;
        protected string name, department;
        protected double salary, hra, da, ta, pf, gross;
        private static int count;
        public Employee()
        {
            ID = 0;
            name = "";
            salary = 0.0;
        }

        public Employee(string name, double salary)
        {
            count++;
            this.ID = count;
            this.name = name;
            this.salary = salary;
        }
        public static int GetEmpCount()
        {
            return count;
        }

        public virtual void CalculateSalary()
        {
            hra = salary * 0.40;
            da = salary * 0.20;
            ta = salary * 0.10;
            pf = salary * 0.12;
            gross = (salary + hra + da + ta) - pf;
        }
        public virtual string Print()
        {
            return $"Employee salary Gross={gross}";
        }

    }

    // Manager is a child class , Employee is base or parent class.
    public class Manager : Employee
    {
        private double FoodAllowance;
        public Manager(double FoodAllownace, string name, double salary) : base(name, salary)
        {
            this.FoodAllowance = FoodAllownace;
        }
        public override void CalculateSalary()
        {
            hra = salary * 0.40;
            da = salary * 0.20;
            ta = salary * 0.10;
            pf = salary * 0.12;
            gross = (salary + hra + da + ta + FoodAllowance) - pf;
        }
        public override string Print()
        {
            return $"Manager's salary Gross={gross}";
        }
    }
}