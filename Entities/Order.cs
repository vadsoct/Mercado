using System;
using System.Globalization;
using System.Collections;
using Mercado.Entities.Enums;
using Mercado.Entities;

namespace Mercado
{
    public class Order
    {
        public DateTime moment { get; set; }
        public OrderStatus status { get; set; }

        
    }
}