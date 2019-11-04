using System;

namespace Exercises01
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlConnection = new SqlConnection("SQL Connection");
            sqlConnection.OpenConnection();
            
        }
    }
}
