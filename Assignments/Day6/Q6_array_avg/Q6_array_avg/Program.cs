using System;


namespace Q6_array_avg
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,sum=0;
            float avg = 0;
            Console.Write("Enter size of array : ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Enter numbers : ");
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                sum += a[i];
            }
            avg = sum / n;
            Console.WriteLine();
            Console.Write("Array is : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ",a[i]);
            }
            Console.WriteLine("\nAverage of all numbers : {0}", avg);
            
        }
    }
}
