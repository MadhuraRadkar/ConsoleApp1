using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Inheritance.cs
{
    public class Animal
    {
        public string Name { get; set; }
    }
    public class Dog : Animal
    {
        public void Display()
        {
            Console.WriteLine("Name of the dog is" +Name);
        }
    }
}
