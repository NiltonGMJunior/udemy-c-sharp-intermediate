﻿using System;

namespace Extensibility
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
            _logger.LogInfo(String.Format("Migration started at {0}", DateTime.Now));

            //  Details of migrating the database.

            _logger.LogInfo(String.Format("Migration finished at {0}", DateTime.Now));
        }
    }
}