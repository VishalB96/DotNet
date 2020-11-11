using System;


namespace Q01_deligateStatic
{
    static class myMathS {
        public static int fact(int n) {
            int fact = 1;
            for (int i = n; i > 0; i--) {
                fact *= i;
            }
            return fact;
        }

        public static int sqr(int n) {

            return n * n;
        }

        public static int cube(int n) { return n * n * n; }
    }

   class myMath
    {
        public int fact(int n)
        {
            int fact = 1;
            for (int i = 1; i<=n; i++)
            {
                fact = fact * i;
            }
            return fact;
        }

        public int sqr(int n)
        {

            return n * n;
        }

        public int cube(int n) { return n * n * n; }
    }

    class Program
    {
        delegate int mathMethods (int n);
        static void Main(string[] args)
        {
            mathMethods Sm1;
            Sm1 = myMathS.fact;

            Console.WriteLine("Static fact of 8 : {0}",Sm1(8));

            Sm1 = myMathS.sqr;
            Console.WriteLine("Static sqr of 8 : {0}",Sm1(8));

            Sm1 = myMathS.cube;
            Console.WriteLine("Static cube of 8 : {0}",Sm1(8));

            Sm1 = new myMath().fact;
            Console.WriteLine("Method fact of 8 : {0}",Sm1(8));

            Sm1 = new myMath().sqr;
            Console.WriteLine("Method sqr of 8 : {0}",Sm1(8));

            Sm1 = new myMath().cube;
            Console.WriteLine("Method cube of 8 ; {0}",Sm1(8));

        }
    }
}
