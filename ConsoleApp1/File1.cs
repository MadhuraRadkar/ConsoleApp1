﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public partial class Calc
    {
        public int Add(int a,int b)
        {
            return a + b;
        }
        public int Sub(int a , int b)
        {
            return a - b;
        }
        public int Mul(int a , int b)
        {
            return a * b;
        }
         // partial method
        partial void SquareRoot(int a);
    }
}
