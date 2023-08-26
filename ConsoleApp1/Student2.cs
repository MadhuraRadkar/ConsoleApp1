using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student2
    {
        private int rollno;
        private string name;
        private double percentage;

        public int Rollno
        {
            get { return rollno; }
            set { rollno = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Percentage
        {
            get { return percentage; }
            set { percentage = value; }
        }
        public string Print()
        {
            return $"student {rollno},{name},{percentage}";
        }
    }
}