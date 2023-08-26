using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Laptop
    {  
        private int noOfUSBPort;
        private double processorSpeed;

        public int NoOfUSBPort
        {
            get { return noOfUSBPort; }
            set { noOfUSBPort = value; }
        }
        public double ProcessorSpeed
        {
            get { return processorSpeed; }
            set { processorSpeed = value; }
        }
    }
}
