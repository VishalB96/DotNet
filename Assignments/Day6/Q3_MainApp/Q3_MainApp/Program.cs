using System;
using Q03_matrixRowAddition;

namespace Q3_MainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int ch=0;
            Matrix2d m1=null;
            do{
                Console.WriteLine("Enter choice : ");
                Console.WriteLine("1.Create New Matrix\n2.Rowwise Sum\n3.Column wise Sum\n4.Exit");
                int.TryParse(Console.ReadLine(), out ch);
                switch (ch) { 
                    case 1:
                        try
                        {
                            if (m1 == null)
                            {
                                m1 = new Matrix2d();
                            }
                            else
                                m1.CreateMatrix();
                        }
                        catch (Exception) {
                            Console.WriteLine("----------Integer values only---------- ");
                        }
                        break;
                    case 2:
                        if (m1 != null)
                            m1.RowAdd();
                        else
                            Console.WriteLine("Matrix empty");
                        break;
                    case 3:
                        if (m1 != null)
                            m1.ColAdd();
                        else
                            Console.WriteLine("Matrix empty");
                        break;
                    case 4:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;


                }
            
            }while(ch!=4);
        }
    }
}
