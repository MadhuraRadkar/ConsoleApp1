using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Bankaccount
    {
        private int accno;
        private string name;
        private double accbalance;
        // Assign the value to the Data member.
        public Bankaccount(int accno,string name,double accbalance)
        {
            this.accno = accno;
            this.name = name;
            this.accbalance = accbalance;
        }
        public void Credit(double creditamt)
        {
            accbalance += creditamt;
            // += is called short hand operator 
            // accbalance = accbalance + creditamt;
        }
        public string Debit(double debitamt)
        {
            string msg = " ";
            if (debitamt <= accbalance)
            {
                accbalance = accbalance - debitamt;
                msg = "Done Transaction";
            }
            else
            {
                msg = "Insufficient balance";
            }
            return msg;
        }
        public string Print()
        {
            return $" Accno={accno}, name={name},accbalance={accbalance}";
        }
    }
}
