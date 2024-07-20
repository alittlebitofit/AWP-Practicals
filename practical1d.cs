// 1. Working with basic C# and ASP .NET 

// d. Create an application to demonstrate
// following operations
// i. Generate Fibonacci series.
// ii. Test for prime numbers.
// iii. Test for vowels.
// iv. Use of foreach loop with arrays
// v. Reverse a number and find sum of digits of a number.

using System;
using System.Linq;

namespace Practical1d
{
    class Practical1d
    {
        internal void GenerateFibo(int n)
        {
            if (n == 0)
            {
                Console.WriteLine(0);
            }
            else if (n == 1)
            {
                Console.WriteLine(0);
                Console.WriteLine(1);
            }
            else if (n > 1)
            {
                Console.WriteLine(0);
                Console.WriteLine(1);

                int n1 = 0, n2 = 1;

                for (int i = 3; i <= n; i++)
                {
                    int n3 = n1 + n2;
                    Console.WriteLine(n3);

                    n1 = n2;
                    n2 = n3;
                }

            }


        }

        internal bool CheckPrime(int n)
        {
            for (int i = 2; i < n / 2; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        internal bool CheckVowel(char c)
        {
            string[] vowels = { "a", "e", "i", "o", "u" };
            return vowels.Contains(c.ToString().ToLower());
        }

        internal void DisplayColors()
        {
            string[] colors = { "violet", "indigo", "blue", "green", "yellow", "orange", "red" };
            foreach(string color in colors)
            {
                Console.WriteLine(color);
            }
        }

        internal void ReverseNumber(int n)
        {
            int reverse = 0;
            int ognum = n;
            while (n > 0)
            {
                int remainder = n % 10;
                reverse *= 10;
                reverse += remainder;
                n /= 10;
            }

            Console.WriteLine($"Reverse of {ognum} is {reverse}");
        }

        internal void SumOfDigits(int n)
        {
            int ognum = n;
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }

            Console.WriteLine($"Sum of digits in {ognum} is {sum}");
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Practical1d practical1d = new Practical1d();

            // v. Reverse a number and find sum of digits of a number.

            int choice;

            do
            {
                Console.WriteLine("1. Fibonacci Series");
                Console.WriteLine("2. Prime");
                Console.WriteLine("3. Vowels");
                Console.WriteLine("4. foreach with arrays");
                Console.WriteLine("5. Reverse and sum");
                Console.WriteLine("6. Exit");

                Console.Write("Enter your choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the size of fibonacci series: ");
                        int n = int.Parse(Console.ReadLine());
                        practical1d.GenerateFibo(n);
                        break;
                    case 2:
                        Console.Write("Enter a number to check for prime: ");
                        n = int.Parse(Console.ReadLine());
                        if(practical1d.CheckPrime(n))
                        {
                            Console.WriteLine($"{n} is a prime number");
                        }
                        else
                        {
                            Console.WriteLine($"{n} is not a prime number");
                        }
                        break;
                    case 3:
                        Console.Write("Enter a character to check for vowel: ");
                        char c = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        if (practical1d.CheckVowel(c))
                        {
                            Console.WriteLine($"{c} is a vowel");
                        }
                        else
                        {
                            Console.WriteLine($"{c} is not a vowel");
                        }
                        break;
                    case 4:
                        practical1d.DisplayColors();
                        break;
                    case 5:
                        Console.Write("Enter a number to reverse and sum its digits: ");
                        n = int.Parse(Console.ReadLine());
                        practical1d.ReverseNumber(n);
                        practical1d.SumOfDigits(n);
                        break;
                    default:
                        break;
                }

                Console.WriteLine("\n====================\n");

            } while (choice != 6);

        }
    }
}
