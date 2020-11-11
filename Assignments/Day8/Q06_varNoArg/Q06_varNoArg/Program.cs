using System;


namespace Q06_varNoArg
{
    class MyMath {

        public int sum(out int sum ,params int[] nos) {
            sum = 0;
            foreach (int n in nos) {
                sum += n;
            }
            return sum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyMath m1 = new MyMath();
            int sum = 0;
            m1.sum(out sum, 12, 312, 21, 43);
           Console.WriteLine(sum);

        }
    }
}
