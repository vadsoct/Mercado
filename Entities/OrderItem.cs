using System;
using System.Text;
using System.Globalization;
using System.Collections;
using Mercado.Entities.Enums;
using Mercado.Entities;
using System.Collections.Generic;


namespace Mercado.Entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price {get; set;}
        public Product Product {get; set;} 



        public OrderItem()
        {            
        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        } 

        public double SubTotal()
        {
            return Price * Quantity;
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