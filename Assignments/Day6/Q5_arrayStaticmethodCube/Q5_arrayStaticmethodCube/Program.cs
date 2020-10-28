using System;


namespace Q5_arrayStaticmethodCube
{
    class Program
    {
        static void cubeOfArray(int[] a) { 
            int size =a.Length;
            for (int i = 0; i < size; i++) {
                a[i] = a[i] * a[i] * a[i];
            }
        }

        static void printArray(int[] a) { 
            int size = a.Length;
            for(int i=0;i<size;i++){
                Console.Write("{0} ",a[i]);
            } Console.WriteLine();
        }
        static void Main(string[] args)
        {

            int n;
            Console.Write("Enter the size of array : ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Enter data : ");
            for (int i = 0; i < n; i++) {
                a[i] = int.Parse(Console.ReadLine());
            }

            printArray(a);
            Console.WriteLine("After cubing array");
            cubeOfArray(a);
            printArray(a);


        }
    }
}
