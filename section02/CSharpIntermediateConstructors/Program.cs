using System;

namespace CSharpIntermediateConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1, "John");
            var order = new Order();

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}
