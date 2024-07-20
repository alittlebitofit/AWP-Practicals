// 1. Working with basic C# and ASP.NET

// c. Create an application that receives the
// (Student Id, Student Name, Course Name, Date of Birth)
// information from a set of students.
// The application should also display the
// information of all the students once the data entered.


using System;

namespace Practical1c
{
    struct Student
    {
        public int sid;
        public string sname;
        public string cname;
        public int dd, mm, yy;

        public void display()
        {
            Console.WriteLine("Student ID: " + sid);
            Console.WriteLine("Student name: " + sname);
            Console.WriteLine($"Course name: {cname}");
            Console.WriteLine("DOB: {0}/{1}/{2}", dd, mm, yy);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many students' information you want to accept?: ");
            int n = int.Parse(Console.ReadLine());

            Student[] students = new Student[n];

            for (int i = 0; i < n; i++)
            {
                students[i] = new Student();
                Console.Write("Enter student ID: ");
                students[i].sid = int.Parse(Console.ReadLine());

                Console.Write("Enter student name: ");
                students[i].sname = Console.ReadLine();

                Console.Write("Enter course name: ");
                students[i].cname = Console.ReadLine();

                Console.Write("Enter day: ");
                students[i].dd = int.Parse(Console.ReadLine());

                Console.Write("Enter month: ");
                students[i].mm = int.Parse(Console.ReadLine());

                Console.Write("Enter year: ");
                students[i].yy = int.Parse(Console.ReadLine());

                Console.WriteLine();
            }

            Console.WriteLine("******* Accepted Student Info *******");

            foreach (Student student in students)
            {
                Console.WriteLine("================");
                student.display();
                Console.WriteLine("================");
            }

        }
    }
}
