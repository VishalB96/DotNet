using System;


namespace Q05_GetType_BaseType
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter value : ");
            var n=Console.ReadLine();
            Console.WriteLine("{0}\n{1}", n.GetType(), n.GetType().BaseType);
            Console.Write("Enter value : ");
            int n1;
            bool b1 = int.TryParse(Console.ReadLine(),out n1);
            Console.WriteLine("{0}\n{1}", n1.GetType(), n1.GetType().BaseType);
            
        }
    }
}
