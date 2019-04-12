using System;
using Mercado.Entities.Enums;
using System.Collections;
using System.Globalization;

namespace Mercado.Entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }

        

        public OrderItem()
        {            
        }

        public OrderItem(int quantity, double Price)
        {
            Quantity = quantity;
            Price = price;
        } 

        public double SubTotal()
        {
            double st = Price * Quantity;
            return st;
        }
    }
}