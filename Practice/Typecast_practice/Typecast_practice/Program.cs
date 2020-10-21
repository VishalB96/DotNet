using System;


namespace Typecast_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b1=3, b2=5;
            byte b3 =(byte) (b1 +b2);
            int b4 = b1 + b2;
            int b5 = 255;
            int b6 = b5 + b4;
            Console.WriteLine(b6);
            //Console.ReadLine();
            short s1=31  ,s2 = 32;
            short s4 = (short)(s1 + s2);
            
            int s5 = (s1 + s2);
            Console.WriteLine("s4 = {0}\ns5={1}", s4, s5);
            //Console.ReadLine();
            float f1 = 50, f2 = 89;
            float f3 = f1 * 45;
            int n1 = 9;
            int n2 = n1 *(int) (34.8);

            byte b11 = 6;
            byte b12 = 250;
            // This time, tell the compiler to add CIL code
            // to throw an exception if overflow/underflow  takes place.


            checked
            {
                byte sum = (byte)(b11 + b12);
                Console.WriteLine("sum = {0}", sum);

                Console.ReadLine();
            }

        }
    }
}
