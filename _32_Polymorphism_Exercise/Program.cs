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
        }
    }
}
