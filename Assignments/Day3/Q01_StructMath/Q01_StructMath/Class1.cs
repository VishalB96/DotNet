using System;


namespace Q01_StructMath
{
       public struct math {
            public static double sqr(int n) {
                return (n * n);
            }

            public static double cube(int n) {
                return (sqr(n) * n);
            }
        }
    
}
