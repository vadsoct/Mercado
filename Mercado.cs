using System;
using System.Globalization;
using System.Collections;
using Mercado.Entities.Enums;
using Mercado.Entities;

namespace Mercado
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Quais os dados do Cliente: ");
            
            System.Console.WriteLine("Nome: ");
            string name = Console.ReadLine();
            System.Console.WriteLine("E-mail: ");
            string email = Console.ReadLine();
            System.Console.WriteLine("Nascimento: (DD/MM/YYYY)");
            DateTime nascimento = DateTime.Parse(Console.ReadLine());

            Client C1 = new Cliente(name,email,nascimento); 
            OrderStatus orderStat = Enum.Parse<OrderStatus>(Processing);

            System.Console.WriteLine("how many orders ?" ); 
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i <= n; i++)
            {
                
            }


        }
    }
}
