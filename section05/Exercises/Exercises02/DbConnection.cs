using System;

namespace Exercises01
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; private set; }
        public TimeSpan Timeout { get; set; }

        protected DbConnection(string connectionString)
        {
            if (String.IsNullOrWhiteSpace(connectionString ))
                throw new ArgumentException("Connection string can not be null or empty.");
            this.ConnectionString = connectionString;
        }

        public abstract void OpenConnection();
        public abstract void CloseConnections();

    }
}