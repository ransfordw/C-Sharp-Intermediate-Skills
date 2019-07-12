using System;

namespace _32_Polymorphism_Exercise
{
        public class SqlConnection : DbConnection
        {
            public SqlConnection(string connectionString) : base(connectionString)
            {
            }

            public override void Close()
            {
                Console.WriteLine("You closed the Sql Connection.");
            }

            public override void Open()
            {
                Console.WriteLine("You opend a new Sql Connection");
            }
        }
    }
