using System;


namespace Q4_5_6_Lib
{
    public class ArrayAssignments
    {
        int[] arr;
        int size;

        public ArrayAssignments(int size) {
            this.size=size;
            arr=new int[size];
            Console.WriteLine("Enter numbers ");
            for (int i = 0; i < size; i++) {
                arr[i]=int.Parse(Console.ReadLine());
            }
        }
    }
}
