using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        protected string name;
        protected int age;
        protected long aadharno;
        public Person(string name , int age , long aadharno)
        {
            this.name = name;
            this.age = age;
            this.aadharno = aadharno;
        }
        public virtual string Display()
        {
            return $"{name},{age}, {aadharno}";
        }
      

    }
    // Patient is child class , Person is Parent class or base.
    public class Patient : Person
    {
        private string bloodgroup , gender;
        private int fees;
        public Patient( string bloodgroup ,string gender,int fees,string name,int age , long aadharno):base(name , age , aadharno)
        {
            this.bloodgroup = bloodgroup;
            this.gender = gender;
            this.fees = fees;
        }
        public override string Display()
        {
            return $"{name},{age},{aadharno},{bloodgroup},{gender},{fees}";
        }
        
    }
}
