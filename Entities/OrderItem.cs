using System;
using Mercado.Entities.Enums;
using System.Collections;
using System.Globalization;

namespace Mercado.Entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public Product Prod {get; set;} = new Product();



        public OrderItem()
        {            
        }

        public OrderItem(int quantity)
        {
            Quantity = quantity;
            Price = Product.price;
            Name = Product.name;
        } 

        public double SubTotal()
        {
            double st = Price * Quantity;
            return st;
        }
        
         public override string ToString()
        {
            return Product.Name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + Quantity
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}