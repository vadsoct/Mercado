using System;
using System.Text;
using System.Globalization;
using System.Collections;
using Mercado.Entities.Enums;
using Mercado.Entities;
using System.Collections.Generic;

namespace Mercado
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Quais os dados do Cliente: ");
            System.Console.WriteLine("Nome: ");
            string clientname = Console.ReadLine();
            System.Console.WriteLine("E-mail: ");
            string email = Console.ReadLine();
            System.Console.WriteLine("Nascimento: (DD/MM/YYYY)");
            DateTime nascimento = DateTime.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter order data: ");
            System.Console.Write("Status: ");            
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Cliente(clientname,email,nascimento);             
            Order order  = new Order(DateTime.Now, status, client);

            System.Console.WriteLine("How many diferents itens will be bought: ");
            int n = int.Parse(Console.ReadLine());

            for(int i=0; i <= n; i++)
            {
                System.Console.WriteLine("Enter with the name of Product: ");
                string NProdutc = Console.ReadLine();
                System.Console.WriteLine("enter with the product price: ");
                double PPrice = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                
                Product Produto = new Product(NProduto,PPrice);

                System.Console.WriteLine("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, PPrice, Produto);

                A1.addOrder(orderItem);
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Order summary: ");
            System.Console.WriteLine(Order);


        }
    }
}
