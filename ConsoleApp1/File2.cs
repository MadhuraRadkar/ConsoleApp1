using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public partial class Calc
    {
        public int Square(int a)
        {
            SquareRoot(a);
            return a * a;
        }
        partial void SquareRoot(int a)
        {   // partial method
            Console.WriteLine("Square root is " +Math.Sqrt(a));
        }
    }
}
