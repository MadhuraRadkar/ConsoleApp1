using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Writtentest3.cs
{
    public class Employeees
    {
        public int Id { get; }
        public string Name { get; }
        public double Basicsalary { get; }
        public Employeees(int id, string name ,  double basicsalary)
        {
            Id = id;
            Name = name;
            Basicsalary = basicsalary;
        }
        public double CalculateGrossSalary()
        {
            double hra = 0.4 * Basicsalary;
            double ta = 0.2 * Basicsalary;
            double pf = 0.12 * Basicsalary;
            double grossSalary = Basicsalary + hra + ta - pf;
            return grossSalary;
        }
        public override string ToString()
        {
            double grossSalary = CalculateGrossSalary();
            return $"Employee ID = {Id},Name = {Name}, Basicsalary = {Basicsalary}, Gross Salary = {grossSalary}";
        }

    }
}
