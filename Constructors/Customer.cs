using System.Collections.Generic;

namespace Constructors
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }

        public Customer(int id) : this()
        {
            this.Id = id;
        }

        public Customer(int id, string name) : this (id)
        {
            this.Name = name;
        }

        // The above code is the same as follows:

        //  public Customer()
        //  {
        //      Orders = new List<Order>();
        //  }

        //  public Customer(int id)
        //  {
        //      Orders = new List<Order>();
        //      this.Id = id;
        //  }

        //  public Customer(int id, string name)
        //  {
        //      Orders = new List<Order>();
        //      this.Id = id;
        //      this.Name = name;
        //  }
    }
}