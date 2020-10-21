using System;


namespace Q06_GetTypeClassREF
{
    public class emp {
        public double salary;

    }
    class Program
    {
        static void Main(string[] args)
        {
            emp e1 = new emp();
            Console.WriteLine("type of e1 : {0}\nparent of e1 : {1}", e1.GetType(), e1.GetType().BaseType);
            Console.WriteLine("type of salary : {0}", e1.salary.GetType());
        }
    }
}
