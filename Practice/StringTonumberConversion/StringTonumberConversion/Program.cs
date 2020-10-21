using System;


namespace StringTonumberConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "45";

            int i1 = int.Parse(s1);
            int i2 = Convert.ToInt32(s1);
            float f1 = float.Parse(s1);
            float f2 = Convert.ToSingle(s1);
            int i3;
            float f3;

            bool b1 = int.TryParse(s1,out i3);
            bool b2 = float.TryParse(s1, out f3);
            int i4;
            if (int.TryParse(Console.ReadLine(), out i4))
                Console.WriteLine("converted ");
            else
                Console.WriteLine("Not converted");
            
            checked {
                string s2 = null;
                //int i5 = int.Parse(s2);
                int i5 = Convert.ToInt32(s2);
                Console.WriteLine(s1);
                Console.WriteLine(i5);
                Console.ReadLine();
            }


        }
    }
}
