using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employee3
    {     // override
        private int id;
        private string name;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public virtual void DisplayRole()
        {
            Console.WriteLine("Employee");
        }
    }
    public class Manager1 : Employee3
    {
        public override void DisplayRole()
        {
            Console.WriteLine("Manager");
        }
    }
    public class RegualrEmployee : Employee3
    {
        public override void DisplayRole()
        {
            Console.WriteLine("Regular Employee");
        }
    }
}
