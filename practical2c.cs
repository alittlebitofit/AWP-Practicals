// 2. Working with Object Oriented C# and ASP.NET

// c. Create simple application to demonstrate
// use of following concepts:
//  i. Using Delegates and events
//  ii. Exception handling

using System;

namespace Practical2c
{
    public delegate int MyMaths(int x, int y);
    delegate void MCast(string msg);

    class Test
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public int Sub(int x, int y)
        {
            return x - y;
        }

        internal void Show(string s)
        {
            Console.WriteLine("showing");
        }
        internal void Display(string s)
        {
            Console.WriteLine("displaying");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Single-cast delegation");
            Test t1 = new Test();
            MyMaths m1 = new MyMaths(Test.Add);
            MyMaths m2 = new MyMaths(t1.Sub);

            Console.WriteLine(m1(10, 20));
            Console.WriteLine(m2(10, 20));


            Console.WriteLine("\n\n\nMulti-cast delegation");
            MCast mc1 = new MCast(t1.Show);
            MCast mc2 = new MCast(t1.Display);
            MCast mc3 = mc1 + mc2 + mc2 + mc1 + mc1 + mc2;
            mc3("");






            Console.WriteLine("\n\n\n==========EXCEPTION HANDLING==========");
            int[] nums = { 1, 2, 3, };
            // Console.WriteLine(nums[nums.Length]); // This line causes Runtime Exception

            for (int i = 0; i <= nums.Length; i++)
            {
                try
                {
                    Console.WriteLine(nums[i]);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                catch
                {
                    Console.WriteLine("Contact admin");
                }
                finally
                {
                    Console.WriteLine(15454);
                }
            }


            Console.WriteLine("\n\n\n==========USER-DEFINED EXCEPTION HANDLING==========");
            Console.Write("Enter a number before 1 and 10: ");

            try
            {
                int num = int.Parse(Console.ReadLine());
                if (num > 10 || num < 1) throw new MyException("Number is not between 1 and 10");
            }
            catch (MyException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Finally getting executed after Trial and Error");
            }
        }
    }

    class MyException : Exception
    {
        internal MyException() : base() { }

        internal MyException(string msg) : base(msg) { }
    }
}
