﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Car
    {
        public string Model { get; set; }
        public int TotalCarSold { get; set; }

        public string GetCarDetails()
        {
            return $"Model={Model}";
        }





    }


}
