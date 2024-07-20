// 1. Working with basic C# and ASP.NET 

// b. Create an application
// to demonstrate string operations.

using System;

namespace Practical1b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter String: ");
            string s = Console.ReadLine();

            Console.WriteLine(s.ToUpper());
            Console.WriteLine(s.ToLower());
            Console.WriteLine(s.Contains("lol"));
            Console.WriteLine(s.Length);
            Console.WriteLine(s.Trim());
            Console.WriteLine(s.TrimStart().Length);
            Console.WriteLine(s.TrimEnd().Length);
            Console.WriteLine(s.IndexOf("h"));
            Console.WriteLine(s[s.Length - 1]);
            Console.WriteLine(s.Concat("hey jude"));
            Console.WriteLine(s.EndsWith("jude"));
            Console.WriteLine(s.Equals("jude"));
            Console.WriteLine(s.GetType());
            Console.WriteLine(s.Insert(3, "don't be afraid"));
            Console.WriteLine(s.LastIndexOf("will"));
            Console.WriteLine(s.Remove(2, 3));
            Console.WriteLine(s.Replace("haha", "lala"));
            Console.WriteLine(s.Reverse());
            Console.WriteLine(s.StartsWith("he"));
            Console.WriteLine(s.Substring(4));
        }
    }
}
