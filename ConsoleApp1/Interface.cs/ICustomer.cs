using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interface.cs
{
    public interface ICustomer
    {
        string Display();
    }
    public interface IOrders
    {
        string Display();
    }
    public class Transaction : ICustomer, IOrders
    {   // Explicit interface implementation.
        string ICustomer.Display()
        {
            return "Customer details";
        }
        string IOrders.Display()
        {
            return "Order details";
        }
    }
}
