using System;

namespace _32_Polymorphism_Exercise
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override void Close()
        {
            Console.WriteLine("You closed the Oracle Connection");
        }

        public override void Open()
        {
            Console.WriteLine("You opened a new Oracle Connection");
        }
    }
}

