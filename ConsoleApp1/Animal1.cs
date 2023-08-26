using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Animal1
    {
        public static string animalType = "Dog";
        public static void MakeSound()
        {
            Console.WriteLine("The animal makes sound");
        }
        public static class StaticClass
        {
            public static void Staticmethod()
            {
                Console.WriteLine("This is static method");

            }
        }
        static Animal1()
        {
            Console.WriteLine("This is static constructor");

        }



    }
}
