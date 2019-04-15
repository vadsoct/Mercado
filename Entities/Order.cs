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
            Items.Add(item);
        }

        public void removeItem(OrderItem item )
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double p = 0.0;
            foreach(OrderItem item  in Items ){
            p += item.SubTotal();            
            } 
            return p;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Cliente);
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