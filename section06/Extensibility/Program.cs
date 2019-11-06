namespace Extensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new  FileLogger(@"C:\Users\Nilton\Documents\Github\udemy-c-sharp-intermediate\section06\Extensibility\log.txt"));
            dbMigrator.Migrate();
        }
    }
}
