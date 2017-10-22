using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public class ProductClass
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }

        public ProductClass(string name, double price, double discount)
        {
            this.Name = name;
            this.Price = price;
            this.Discount = discount;
        }

        public double PriceDiscount()
        {
            return this.Price * (this.Discount/100);
        }

        public static double operator +(ProductClass obj1, ProductClass obj2)
        {
            return obj1.Price + obj2.Price;
        }
    }
}
