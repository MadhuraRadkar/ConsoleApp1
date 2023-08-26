using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student3
    {
        private int id;
        private string name;
        public Student3(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public int getId()
        {
            return id;
        }
        public void setCustomData(int customid , string customname)
        {
            id = customid;
            name = customname;
        }
        public void DisplayData()
        {
            Console.WriteLine("ID:"+id+ "Name:" +name);
        }
    }
}
