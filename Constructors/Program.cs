using System;
using System.Collections.Generic;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1, "Ransford");
            customer.Id = 1;
            customer.Name = "Ransford";
            var order = new Order();
            //Bad practice: the following line fixes a null reference issue that can be completed by initializing the customer class with a new, empty list
            //customer.Orders = new List<Order>();
            customer.Orders.Add(order);

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
           
        }
    }
}
