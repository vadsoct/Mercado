using System;
using Mercado.Entities.Enums;
using System.Collections;
using System.Globalization;

namespace Mercado.Entities
{
    public class Product
    {
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }

        public Product(int quantity, double price)
        {
            quantity = Quantity;
            price = Price; 
        }
    } 
}