using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {
        // create student class = with rollno,nsame,branch,percentage accept the data & display details of student.
        // decleration of data members.
        private int rollno;
        private string name, branch;
        private string grade;
        private double percentage, math, phy, chem, total;

        public Student() // parameter less constructor.
        { // assign default values.
            rollno = 0;
            name = " ";
            branch = "";

        }
        public Student(int rollno, string name, string branch, double math, double phy, double chem)
        {  // parametric constructor.
            this.rollno = rollno;
            this.name = name;
            this.branch = branch;
            this.math = math;
            this.phy = phy;
            this.chem = chem;
        }

        // assign value to each data member.

        //public void AcceptStudentData(int rollno, string name, string branch, double math, double phy, double chem)
        //{
        //    this.rollno = rollno;
        //    this.name = name;
        //    this.branch = branch;
        //    this.math = math;
        //    this.phy = phy;
        //    this.chem = chem;
        //}
        public void CalculatePercentage()
        {
            total = math + phy + chem;
            percentage = (total / 300) * 100;
        }
        public void AssignGrade()
        {
          if (percentage >= 80)
            {
                Console.WriteLine("Grade A");
            }
            else if (percentage>=60)
            {
                Console.WriteLine("Grade B");

            }
            else if (percentage >= 40)
            {
                Console.WriteLine("Grade C");
            }
            else
            {
                Console.WriteLine("fail");
            }

        }
       
        public string Print() // return data from each data member.
        {
            return $"Student rollno={rollno}, name={name}, branch={branch}, total={total},percentage={percentage},Grade={grade}";

        }

    }
}
