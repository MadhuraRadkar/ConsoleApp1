using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SWp
    {
        public static void Swap (ref int a , ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }
      
    }
}
