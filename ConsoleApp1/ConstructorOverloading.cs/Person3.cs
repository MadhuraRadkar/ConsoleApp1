using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ConstructorOverloading.cs
{
    public class Person3
    {
        // Show example for constructor overloading.
        public string Name { get; set; }
        public int Age { get; set; }
        public Person3()
        {
            Name = " ";
            Age = 0;
        }
        public Person3 (string name , int age)
        {
            Name = name;
            Age = age;
        }
        public string Print()
        {
            return $" {Name},{ Age}";
        }
    }
}
