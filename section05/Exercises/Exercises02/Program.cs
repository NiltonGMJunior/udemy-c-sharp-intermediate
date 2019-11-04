using System;
using System.Linq;
using Exercises01;

namespace Exercises02
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlConnection = new SqlConnection("SQL Connection");
            var oracleConnection = new OracleConnection("Oracle Connection");

            var sqlCommand = "SELECT * FROM sql_table;";
            var sqlDbCommand = new DbCommand(sqlConnection, sqlCommand);
            sqlDbCommand.Execute();

            var oracleCommand = "SELECT * FROM oracle_table";
            var oracleDbCommand = new DbCommand(oracleConnection, oracleCommand);
            oracleDbCommand.Execute();
        }
    }
}
