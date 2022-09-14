using System;

namespace Pythagorean_theorem
{
    class Program
    {
        static void Main(string[] args)
        {
            // this is a simple application to solve Pythagorean theorem  

            Console.WriteLine("Enter First Value: ");
            double Value1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Second Value: ");
            double Value2 = Convert.ToDouble(Console.ReadLine());

            double result = Math.Sqrt((Math.Pow(Value1, 2) + Math.Pow(Value2, 2)));
            Console.WriteLine(result);

        }
    }
}
