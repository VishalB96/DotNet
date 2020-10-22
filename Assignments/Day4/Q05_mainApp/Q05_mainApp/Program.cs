using System;
using Q05_calculator;

namespace Q05_mainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int ch;
            float n;
            do{
                Console.WriteLine("Enter number : ");
                n = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter choice : \n1.square\n2.cube\n3.absolute value\n4.floor\n5.Cealing\n6.Exit\n");
                ch = int.Parse(Console.ReadLine());
                switch (ch) { 
                    case 1:
                        Console.WriteLine("Square of {0} : {1}", n, Calculator.square(n));
                        break;
                    case 2:
                        Console.WriteLine("Cube of {0} : {1}", n, Calculator.cube(n));
                        break;
                    case 3:
                        Console.WriteLine("Absolute value of {0} : {1}", n, Calculator.absolute(n));
                        break;
                    case 4:
                        Console.WriteLine("Square of {0} : {1}", n, Calculator.floor(n));
                        break;
                    case 5:
                        Console.WriteLine("Square of {0} : {1}", n, Calculator.ceil(n));
                        break;
                    case 6:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Enter valid choice");
                        break;
                }
            }while(ch!=6);
        }
    }
}
