using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Product
    {
        private int id, discount , discountprice;
        private string name;
        private int price;
        public Product(int id, string name, int price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }
        public void DiscountedPrice(int discountpercentage)
        {
            discountprice = price - (price * discountpercentage/100);
        }
        public string print()
        {
            return $" id ={id}, name={name},originalprice={price},priceafterdiscount={discountprice}";

        }
    }
}
