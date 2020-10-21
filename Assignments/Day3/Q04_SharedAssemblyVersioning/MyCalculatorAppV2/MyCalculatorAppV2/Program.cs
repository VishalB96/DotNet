using System;
using Day3MyCalculator;


namespace MyCalculatorAppV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cube of 23 : {0}",MyCalculator.cube(23));
            Console.WriteLine("34 + 54 : {0}", MyCalculator.add(34, 54));
        }
    }
}
