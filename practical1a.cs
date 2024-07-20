//1.Working with basic C# and ASP .NET

//a. Create an application that obtains
// four int values from the user
// and displays the product.


using System;

namespace Practical1a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int no1, no2, no3, no4, ans;

            Console.Write("First number: ");
            no1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Second number: ");
            no2 = int.Parse(Console.ReadLine());

            Console.Write("Third number: ");
            no3 = int.Parse(Console.ReadLine());

            Console.Write("Fourth number: ");
            no4 = int.Parse(Console.ReadLine());

            ans = no1 * no2 * no3 * no4;
            Console.WriteLine($"Product of {no1}, {no2}, {no3} and {no4} is {ans}");
        }
    }
}
