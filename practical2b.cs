// 2. Working with Object Oriented C# and ASP.NET

// b. Create simple application to demonstrate use of following concepts
//   i. Function Overloading
//   ii. Inheritance (all types)
//   iii. Constructor overloading
//   iv. Interfaces

using System;

namespace Practical2b
{

    class Practical2b
    {
        internal void Sum(int n1, int n2)
        {
            Console.WriteLine($"Sum of {n1} and {n2} is {n1 + n2}");
        }
        internal void Sum(int n1, int n2, int n3)
        {
            Console.WriteLine($"Sum of {n1}, {n2} and {n3} is {n1 + n2 + n3}");
        }

        internal Practical2b()
        {
            Console.WriteLine("Non-parameterized constructor invoked");
        }

        internal Practical2b(string s)
        {
            Console.WriteLine("Parameterized overloaded constructor invoked with argument: " + s);
        }
    }

    interface Animal
    {
        void move();
    }

    class Dog : Animal
    {
        
        public void move()
        {
            Console.WriteLine("Dog is moving");
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********This is a demonstration of Constructor overloading**********");
            Practical2b practical2b = new Practical2b();
            new Practical2b("Hey");

            Console.WriteLine();
            Console.WriteLine("**********This is a demonstration of Method overloading**********");
            practical2b.Sum(1, 2);
            practical2b.Sum(1, 2, 3);


            Console.WriteLine();
            Console.WriteLine("**********This is a demonstration of Interface**********");
            new Dog().move();

            Console.WriteLine();
            Console.WriteLine("**********This is a demonstration of single inheritance**********");
            new ParentClass();

            Console.WriteLine();
            Console.WriteLine("**********This is a demonstration of multilevel inheritance**********");
            new ChildClass();

            Console.WriteLine();
            Console.WriteLine("**********This is a demonstration of hierarchical inheritance**********");
            new DerivedClass1();
            new DerivedClass2();
        }
    }
}

class GrandParentClass {
    internal int n = 10;
}

class ParentClass : GrandParentClass {
    internal ParentClass()
    {
        Console.WriteLine(GetType() + $" inherits value of n({n}) from " + GetType().BaseType);
    }
}

class ChildClass : ParentClass {
    internal ChildClass()
    {
        Console.WriteLine(GetType() + $" inherits value of n({n}) from " + GetType().BaseType
            + " which first inherits from " + GetType().BaseType.BaseType);
    }
}



class BaseClass
{
    internal BaseClass()
    {
        Console.WriteLine(GetType().BaseType + " is called from " + GetType());
    }
}

class DerivedClass1 : BaseClass {}
class DerivedClass2 : BaseClass {}
