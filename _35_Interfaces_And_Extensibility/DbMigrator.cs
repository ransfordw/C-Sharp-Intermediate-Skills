using System;

namespace _35_Interfaces_And_Extensibility
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo("Migration started at " + DateTime.Now);

            // Details of migrating the db

            _logger.LogInfo("Migrating finished at " + DateTime.Now);
        }
    }
}
