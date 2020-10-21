using System;
using Q01_StructMath;
using Q02_structFactorial;
using Q03_structEmpConstructor;


namespace Q1_2_3MainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ASSIGNMENT 1");
            Console.WriteLine("Enter number : ");
            int n;
            bool b = int.TryParse(Console.ReadLine(), out n);
            Console.WriteLine("Square of {0} : {1}\nCube of {0} : {2}",n,math.sqr(43), math.cube(43));
            Console.WriteLine("\n----------------------------------------------------------------\n");
            Console.WriteLine("Assignment 2");
            Console.WriteLine("Enter no to find factorial : ");
            int n1;
            bool b1 = int.TryParse(Console.ReadLine(), out n1);
            calculator.fact(n1);
            Console.WriteLine("\n----------------------------------------------------------------\n");
            Console.WriteLine("Assignment 3");
            Console.WriteLine("Enter Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Salary : ");
            double salary;
            bool b2 = double.TryParse(Console.ReadLine(), out salary);
            emp e1 = new emp(name, salary);
            e1.dispEmp();
        }
    }
}
