﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.AbstractClass.cs
{ 
    abstract public class Shape
    {
        public Shape()
        {

        }
        public abstract string Draw(string name);
        public abstract void Area();
        public string Display()
        {
            return "This is shape class";
        }
    }

    public class Rectangle : Shape
    {
        private int l , b;
        private double area;
        public Rectangle(int l , int b )
        {
            this.l = l;
            this.b = b;
        }
        public override string Draw(string name)
        {
            return name;
        }
        public override void Area()
        {
            area = l * b;
        }
        public string print()
        {
            return $"Area of Rectangle is {area}";
        }

    }
}
