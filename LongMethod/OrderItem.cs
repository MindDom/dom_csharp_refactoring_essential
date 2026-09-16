using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongMethod
{
    public class OrderItem
    {
        public double Price { get; }
        public double Quantity { get; }

        public double OrderTotal => Price * Quantity;

        public OrderItem(double price, double quantity)
        {
            Price = price;
            Quantity = quantity;
        }
    }
}
