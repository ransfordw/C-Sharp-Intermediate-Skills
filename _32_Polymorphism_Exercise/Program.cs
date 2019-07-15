using System;

namespace _32_Polymorphism_Exercise
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var sqlConn = new SqlConnection("sql_connection");
            var oracleConn = new OracleConnection("oracle_connection");
            sqlConn.Open();
            sqlConn.Close();
            oracleConn.Open();
            oracleConn.Close();

            var command = new DbCommand(new SqlConnection("Sql-Connection-String"), "Print: Hello World");

            command.Execute();

            var command2 = new DbCommand(new OracleConnection("Oracle-Connection-String"), "Print: Hello World");

            command2.Execute();

            Console.ReadKey();
        }
    }

    public class DbCommand
    {
        public string Instruction { get; set; }
        public DbConnection Connection { get; set; }
        public DbCommand(DbConnection connection, string instruction)
        {
            if (connection == null || instruction == null)
                throw new NullReferenceException();
            Connection = connection;
            Instruction = instruction;
        }

        public void Execute()
        {
            Connection.Open();
            Console.WriteLine(Instruction);
            Connection.Close();
        }
    }
}
