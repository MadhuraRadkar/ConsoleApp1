using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Inheritance.cs
{
    public class Vehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Engine started");
        }
    }

    public class Bike : Vehicle
    {
        public void Drive()
        {
            Console.WriteLine("Bike is driving");
        }
    }

}
