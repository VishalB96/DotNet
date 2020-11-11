using System;


namespace Q04_swapDemo
{
    class SwapDemo {

        public static void swap(ref int n1, ref int n2) {
            n1 = n1 + n2;
            n2 = n1 - n2;
            n1 = n1 - n2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 2 numbers to swap : \n");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            SwapDemo.swap(ref n1, ref n2);
            Console.Write("Numbers after swap : {0} {1}\n", n1, n2);
        }
    }
}
