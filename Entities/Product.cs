using System;
using System.Text;
using System.Globalization;
using System.Collections;
using Mercado.Entities.Enums;
using Mercado.Entities;
using System.Collections.Generic;

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