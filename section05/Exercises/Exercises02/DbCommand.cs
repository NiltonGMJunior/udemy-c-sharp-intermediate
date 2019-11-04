using System;
using System.IO;
using Exercises01;

namespace Exercises02
{
    public class DbCommand
    {
        private readonly DbConnection _dbConnection;
        private readonly string _command;

        public DbCommand(DbConnection dbConnection, string command)
        {
            if (dbConnection == null)
                throw new ArgumentNullException("Connection can not be a null object");
            if (String.IsNullOrWhiteSpace(command))
                throw  new InvalidDataException("Command can not be null or empty.");
            _dbConnection = dbConnection;
            _command = command;
        }

        public void Execute()
        {
            try
            {
                _dbConnection.OpenConnection();
                Console.WriteLine("Executing command: {0}", _command);
                _dbConnection.CloseConnections();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}