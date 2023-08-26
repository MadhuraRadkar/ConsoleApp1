using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Book
    {
        // create book class with book id,name,price,authername accept the data & display book details.
        private int Id, price;
        private string name, authername;

        public Book()
        {
            Id = 0;
            price = 0;
            name = " ";
            authername = "";
        }

        public Book(int id,int price,string name,string authername)
        {
            this.Id = id;
            this.price = price;
            this.name = name;
            this.authername = authername;
        }

        //public void AcceptBookData(int id ,string nm, int pr, string an)
        //{
        //    Id = id;
        //    name = nm;
        //    price = pr;
        //    authername = an;
        //}
        public string Print()
        {
            return $"BookData :ID={Id},price={price},name={name},authername={authername}";
        }
    }
}
