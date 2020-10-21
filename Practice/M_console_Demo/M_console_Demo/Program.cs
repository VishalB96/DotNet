using System;
using Library1;

namespace M_console_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            MathClass m1 = new MathClass();
            Console.WriteLine(m1.sum(90, -21));
            Console.ReadLine();
        }
    }
}
