using System;


namespace Q04_stringLowercase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter some string : ");
            string str = Console.ReadLine();
            string str1 = str.ToLower();
            Console.Write("String after converting to lowercase : {0}\n",str1);
            if (Object.Equals(str, str1))
                Console.WriteLine("Static equals true");
            else
                Console.WriteLine("static equals false");

            if(str.Equals(str1))
                Console.WriteLine("Equals true");
            else
                Console.WriteLine("Equals false");
            Console.WriteLine(str.GetHashCode());
            Console.WriteLine(str1.GetHashCode());
            
        }
    }
}
