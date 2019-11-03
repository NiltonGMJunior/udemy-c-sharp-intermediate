using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    var point = new Point(10, 20);
            //    point.Move(new Point(40, 60));
            //    Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

            //    point.Move(100, 200);
            //    Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

            //    point.Move(null);
            //    Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("An unexpected error occured.");
            //}

            //var calculator = new Calculator();
            //Console.WriteLine(calculator.Add(1, 2));
            //Console.WriteLine(calculator.Add(1, 2, 3));
            //Console.WriteLine(calculator.Add(1, 2, 3, 4));
            //Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5 }));

            int number;
            try
            {
                number = int.Parse("abc");
                Console.WriteLine(number);
            }
            catch (Exception)
            {
                Console.WriteLine("Conversion failed.");
            }

            var result = int.TryParse("abc", out number);
            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion failed.");
        }
    }
}
