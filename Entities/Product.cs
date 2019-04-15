using System;
using System.Text;
using Mercado.Entities.Enums;
using System.Collections;
using System.Globalization;

namespace Mercado.Entities
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }

        public Product(int name, double price)
        {
            Name = name;
            Price = price; 
        }
    } 
}