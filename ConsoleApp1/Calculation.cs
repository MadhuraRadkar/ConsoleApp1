using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Calculation
    {    // task -> perform addition.
        // method overloading.
        public int Addition(int a , int b)
        {
            return a + b;
        }
        public int Addition(int a , int b , int c)
        {
            return a + b + c;
        }
        public double Addition(int a , double b)
        {
            return a + b;
        }
        public double Addition(double a , double b)
        {
            return a + b;
        }
    }
}
