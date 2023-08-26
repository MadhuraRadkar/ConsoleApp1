using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Date
    {
        // create date class with day,month,year accept data & display date details.
        private int day, year;
        private string month;
        public void AcceptDate(int dd, string mm, int yy)
        {
            day = dd;
            month = mm;
            year = yy;
        }

        public string PrintDate()
        {
            return $"Date: {day} / {month} / {year}";
        }


    }
}

       
       
    
 