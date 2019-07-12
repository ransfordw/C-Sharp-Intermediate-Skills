using System;

namespace _32_Polymorphism_Exercise
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            ConnectionString = connectionString ?? throw new NullReferenceException();
        }

        public abstract void Open();
        public abstract void Close();
    }
}
