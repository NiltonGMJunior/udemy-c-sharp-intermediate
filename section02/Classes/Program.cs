using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //var person = new Person();
            //person.Name = "John";
            //person.Introduce("Mosh");

            var p = Person.Parse("John");
            p.Introduce("Mosh");
        }
    }
}
