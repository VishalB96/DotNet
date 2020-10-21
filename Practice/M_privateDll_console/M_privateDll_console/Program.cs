using System;
using Library1;

namespace M_privateDll_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new MathClass().sum(12, 32));
            Console.ReadLine();
            int s = 45;
            int a;
            bool b = int.TryParse(s,out a);

        }
    }
}
