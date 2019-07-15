using System;

namespace _35_Interfaces_And_Extensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new FileLogger("C:\\Personal Projects\\C-Sharp-Intermediate-Skills\\log.txt"));
            dbMigrator.Migrate();

            Console.ReadKey();
        }
    }
}
