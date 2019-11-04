using System;

namespace Exercises01
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString) { }

        public override void OpenConnection()
        {
            Console.WriteLine("Opening Oracle connection");
        }

        public override void CloseConnections()
        {
            Console.WriteLine("Closing Oracle connection");
        }
    }
}