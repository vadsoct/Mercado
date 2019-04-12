using System;
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
        public Client Clients { get; set;} 
        public list<OrderItem> orderItens { get; set; } = new list<OrderItem>();

        public Order()
        {            
        }

        public Order(DateTime moment, OrderStatus status, Client clients)
        {
            Moment = moment;
            Status = status;
            Clients = clients;

        }
 

        public void addOrder(OrderItem orders )
        {
            orderItem.Add(orders);
        }

        public void addOrder(OrderItem orders )
        {
            orderItem.remove(orders);
        }

        public double total()
        {
            foreach(OrderItem orders  in orderItens ){
            double p = p += OrderItem.subTotal();
            } 
        }

    }
}