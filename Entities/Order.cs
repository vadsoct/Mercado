using System;
using System.Text;
using System.Globalization;
using System.Collections;
using Mercado.Entities.Enums;
using Mercado.Entities;

namespace Mercado
{
    public class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Cliente { get; set;} 
        public list<OrderItem> orderItens { get; set; } = new list<OrderItem>();

        public Order()
        {            
        }

        public Order(DateTime moment, OrderStatus status, Client cliente)
        {
            Moment = moment;
            Status = status;
            Cliente = cliente;

        }
 

        public void addOrder(OrderItem item )
        {
            orderItem.Add(item);
        }

        public void addOrder(OrderItem item )
        {
            orderItem.remove(item);
        }

        public double total()
        {
            double p = 0.0;
            foreach(OrderItem item  in orderItens ){
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