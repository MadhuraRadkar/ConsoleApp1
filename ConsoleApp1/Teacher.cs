using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Teacher       // child class access 2 interface.
    {
        public void Teach()
        {
            Console.WriteLine("Teaching");
        }
    }
    public interface IStudent
    {
        void study();
    }
    public interface IAdmin
    {
        void Manage();
    }
    public class Teacher1 : Teacher,IStudent,IAdmin
    {   // child class access 2 interface.
        public void study()
        {
            Console.WriteLine("Studying");

        }
        public void Manage()
        {
            Console.WriteLine("Managing");

        }

    }

}
