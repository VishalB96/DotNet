using System;


namespace Q02_structFactorial
{
    public struct calculator {

        public static void fact(int n) {
            Console.Write("Factors of {0} : [ ", n);
            for (int i = 1,j=0; i <= n; i++) {
                if (n % i == 0)
                    Console.Write("{0} ", i);
            }
            Console.Write("]");
            
        }
    }
}
