using System;


namespace Q2_methodoverloading
{
    static class myMethods
    {

        public static int sqr(int n)
        {
            Console.WriteLine("inside integer sqr");

            return n * n;
        }
        public static double sqr(int n)
        {
            Console.WriteLine("inside double sqr");
            return n * n;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number(integer)");
                Console.WriteLine(myMethods.sqr(int.Parse(Console.ReadLine())));
                Console.WriteLine("Enter a number(double)");
                Console.WriteLine(myMethods.sqr(double.Parse(Console.ReadLine())));
            }
            catch (FormatException) { Console.WriteLine("invalid input!"); }
        }
    }
}
