using System;
using System.Text;
using System.Globalization;
using Mercado.Entities.Enums;
using Mercado.Entities;
using System.Collections.Generic;

namespace Mercado
{
    public class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Cliente { get; set;} 
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {            
        }

        public Order(DateTime moment, OrderStatus status, Client cliente)
        {
            Moment = moment;
            Status = status;
            Cliente = cliente;

        }
 

        public void addItem(OrderItem item )
        {
            Item.Add(item);
        }

        public void removeItem(OrderItem item )
        {
            Item.remove(item);
        }

        public double Total()
        {
            double p = 0.0;
            foreach(OrderItem item  in Item ){
            p += OrderItem.subTotal();            
            } 
            return p;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items:");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}