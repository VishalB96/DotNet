using System;
using System.Delegate;
using System.Collections;


namespace Q03
    
{
    
    
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter a number : ");
            var ob1 = new { num = int.Parse(Console.ReadLine()) };
            Console.WriteLine("number is {0}", ob1);
        }
    }
}
