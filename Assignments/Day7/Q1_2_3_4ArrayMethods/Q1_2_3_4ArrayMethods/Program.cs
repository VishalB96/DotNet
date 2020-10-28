using System;


namespace Q1_2_3_4ArrayMethods
{
    class Program
    {
        static int[] createArray(int size) {
            int[] arr = new int[size];
            Console.WriteLine("Enter elements : ");
            for (int i = 0; i < size; i++) {
                if (!int.TryParse(Console.ReadLine(), out arr[i]))
                    i--;
            }
            Console.Write("Entered Array : ");
            display(arr);

            return arr;
        }

        static void display(int[] arr) {
            foreach (int i in arr)
                Console.Write(" {0} ", i);
            
        }

        static void sort(int[] arr, bool order) {
            Array.Sort(arr);
            if (order)
                Array.Reverse(arr);
        }

        static int[] copyArray(int[] arr) {
            int[] arr1 = new int[arr.Length];
            Array.Copy(arr, arr1,arr.Length);
            return arr1;
        }
        static void Main(string[] args)
        {
            int[] arr=null;
            int ch = 0;

            
            do {
                Console.WriteLine("Enter choice : \n1.Create New Array.\n2.sort in acsending.\n3.sort in decending\n4.create copy of array\n5.display array\n6.exit");
                int.TryParse(Console.ReadLine(), out ch);
                switch(ch){
                    case 1:
                        int size;
                        Console.Write("Enter size of array : ");
                        int.TryParse(Console.ReadLine(), out size);
                        arr=createArray(size);
                        Console.WriteLine();
                        break;
                    case 2:
                        if (arr == null) {
                            Console.WriteLine("Array empty\n");
                            break;
                        }
                        Console.WriteLine("Before sorting");
                        display(arr);
                        Console.WriteLine();
                        Console.WriteLine("After sorting");
                        sort(arr, false);
                        display(arr);
                        Console.WriteLine();
                        break;
                    case 3:
                        if (arr == null)
                        {
                            Console.WriteLine("Array empty\n");
                            break;
                        }
                        Console.WriteLine("Before sorting");
                        display(arr);
                        Console.WriteLine("After sorting");
                        sort(arr, true);
                        display(arr);
                        Console.WriteLine();
                        break;
                    case 4:
                        if (arr == null)
                        {
                            Console.WriteLine("Array empty\n");
                            break;
                        }
                        int[] arrCpy = new int[arr.Length];
                        Console.Write("Arr : ");
                        display(arr);
                        Console.WriteLine();
                        arrCpy = copyArray(arr);
                        Console.Write("ArrCpy : ");
                        display(arrCpy);
                        Console.WriteLine();
                        break;

                    case 5:
                        if (arr == null)
                        {
                            Console.WriteLine("Array empty\n");
                            break;
                        }
                        display(arr);
                        Console.WriteLine();
                        break;
                    case 6:
                        Console.WriteLine("Exiting....");
                        Console.WriteLine();
                        break;
                    default :
                        Console.WriteLine("Invalid choice");
                        Console.WriteLine();
                        break;

                }
            } while (ch != 6);
        }
    }
}
