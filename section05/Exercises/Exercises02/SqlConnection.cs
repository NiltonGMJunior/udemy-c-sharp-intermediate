using System;

namespace Exercises01
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString) { }

        public override void OpenConnection()
        {
            Console.WriteLine("Opening SQL connection");
        }

        public override void CloseConnections()
        {
            Console.WriteLine("Closing SQL connection");
        }
    }
}