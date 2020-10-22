using System;



namespace Q05_calculator
{
    public class Calculator
    {
        public static float square(float n){
            return n*n;
        }

        public static float cube(float n) {
            return n * n * n;
        }

        public static float absolute(float n) {
            return Math.Abs(n);
        }

        public static float floor(float n) { return (float)Math.Floor(n); }

        public static float ceil(float n) { return (float)Math.Ceiling(n); }
    }
}
