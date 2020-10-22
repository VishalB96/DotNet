using System;
using Q02_Employee;

namespace Q02_mainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name of emp1 : ");
            string name1 = Console.ReadLine();
            Console.WriteLine("Enter {0}'s salary : ", name1);
            double sal1 = double.Parse(Console.ReadLine());
            Employee e1 = new Employee(name1, sal1);
            e1.display();


            Console.WriteLine("\n\nEnter name of emp2 : ");
            string name2 = Console.ReadLine();
            Console.WriteLine("Enter {0}'s salary : ", name2);
            double sal2 = double.Parse(Console.ReadLine());
            Employee e2 = new Employee(name2, sal2);
            e2.display();
        }
    }
}
