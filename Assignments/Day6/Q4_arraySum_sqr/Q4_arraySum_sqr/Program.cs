using System;


namespace Q4_arraySum_sqr
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,sum=0;
            Console.Write("Enter size of array : ");
            n=int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int[] sqrA = new int[n];
            Console.WriteLine("Enter numbers : ");
            for (int i = 0; i < n; i++) {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.Write("Array is : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i]);
                sum += a[i];
                sqrA[i] = a[i] * a[i];

            }
            Console.WriteLine("\nAddition of all numbers : {0}", sum);
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", sqrA[i]);
            }

        }
    }
}
