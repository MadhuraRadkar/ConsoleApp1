using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Mobile
    {
        // Use of base keyword 
        protected string brand;
        protected string model;
        public Mobile(string brand,string model)
        {
            this.brand = brand;
            this.model = model;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine("Brand is " +brand);
            Console.WriteLine("Model is " +model);

        }
    }
    public class Smartphone : Mobile
    {
        protected string operatingSystem;
        public Smartphone(string brand , string model,string operatingSystem) : base (brand , model)
        {
            this.operatingSystem = operatingSystem;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("operating system " + operatingSystem);

        }

    }

}
