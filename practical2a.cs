// 2. Working with Object Oriented C# and ASP.NET

// a. Create simple application to perform following operations:
// i. Finding factorial value
// ii. Money Conversion
// iii. Quadratic Equation
// iv. Temperature Conversion


using System;

namespace Practical2a
{

    class Practical2a
    {
        internal void Factorial(int n)
        {
            int fact = 1;
            for(int i = n; i >= 2; i--)
            {
                fact *= i;
            }

            Console.WriteLine($"Factorial of {n} is {fact}");
        }

        internal void ConversionDToR(double dollar)
        {
            double rupee = dollar * 83;
            Console.WriteLine($"${dollar} = {rupee} rupee(s)");
        }
        internal void ConversionRToD(double rupee)
        {
            double dollar = rupee / 83;
            Console.WriteLine($"{rupee} rupee(s) = ${Math.Round(dollar, 2)}");
        }

        internal void Quadratic()
        {
            Console.Write("Enter Quadratic term: ");
            int quadraticTerm = int.Parse(Console.ReadLine());

            Console.Write("Enter Linear term: ");
            int linearTerm = int.Parse(Console.ReadLine());

            Console.Write("Enter Constant term: ");
            int constantTerm = int.Parse(Console.ReadLine());

            Console.WriteLine($"Quadratic equation: {quadraticTerm}x\xB2 {(linearTerm < 0 ? $"- {-linearTerm}" : $"+ {linearTerm}")}x {(constantTerm < 0 ? $"- {-constantTerm}" : $"+ {constantTerm}")}");
        }

        internal void TemperatureCToF(double celsius)
        {
            double fahrenheit = (celsius * 9) / 5 + 32;
            Console.WriteLine($"{celsius} celsius = {fahrenheit} fahrenheit");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Practical2a practical2A = new Practical2a();

            int choice;

            do
            {
                Console.WriteLine("1. Factorial");
                Console.WriteLine("2. Dollar to Rupee conversion");
                Console.WriteLine("3. Rupee to Dollar conversion");
                Console.WriteLine("4. Quadratic");
                Console.WriteLine("5. Celsius to Fahrenheit");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");

                choice = int.Parse(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        Console.Write("Enter number to find factorial: ");
                        int num = int.Parse(Console.ReadLine());
                        practical2A.Factorial(num);
                        break;
                    case 2:
                        Console.Write("Enter dollar amount: ");
                        double dollar = double.Parse(Console.ReadLine());
                        practical2A.ConversionDToR(dollar);
                        break;
                    case 3:
                        Console.Write("Enter rupee amount: ");
                        double rupee = double.Parse(Console.ReadLine());
                        practical2A.ConversionRToD(rupee);
                        break;
                    case 4:
                        practical2A.Quadratic();
                        break;
                    case 5:
                        Console.Write("Enter temperature in Celsius: ");
                        double celsius = double.Parse(Console.ReadLine());
                        practical2A.TemperatureCToF(celsius);
                        break;
                    default:
                        break;
                }

                Console.WriteLine("\n=========================\n");

            } while(choice != 6);
        }
    }
}
