using System;


namespace Q03_outKeyword
{
    class outDemo {

        public int[] sqrArray(int[] arr, out int sum) {
            int[] arrSqr = new int[arr.Length];
            sum=0;
            int size = arr.Length;
            for (int i = 0; i < size; i++) {
                sum += arr[i];
                arrSqr[i] = arr[i] * arr[i];
            }
            return arrSqr;
        }
    }
    class Program
    {
        static void display(int[] arr) {
            foreach (int i in arr) {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.Write("Enter size : ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++) { arr[i] = int.Parse(Console.ReadLine()); }
            Console.Write("Entered array is : ");
            display(arr);
            int sum = 0;
            int[] arr2 = new outDemo().sqrArray(arr, out sum);
            Console.Write("\nSum of all elements : {0}\nSquare of elements of array : ",sum);
            display(arr2);
            
        }
    }
}
