using System;


namespace Q03_matrixRowAddition
{
    public class Matrix2d
    {
        int[,] Matrix = new int[3, 3];
        public Matrix2d() {
            CreateMatrix();
        }

        public void CreateMatrix() {
            Console.WriteLine("Enter the values");
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    int n;
                    Console.Write("Enter value for [{0}][{1}] : ", i, j);
                    if (!int.TryParse(Console.ReadLine(), out Matrix[i, j]))
                        throw new Exception("Enter a integer");

                }
            }
        }

        public void RowAdd() {
            Console.WriteLine("Row wise sum : ");
            for (int i = 0; i < 3; i++) {
                int sum = 0;
                for (int j = 0; j < 3; j++) {
                    sum += Matrix[i, j];
                }
                Console.WriteLine("sum [{0}] : {1}",i,sum);
            }
        }

        public void ColAdd() {
            for (int i = 0; i < 3; i++) {
                int sum = 0;
                for (int j = 0; j < 3; j++) {
                    sum += Matrix[j, i];
                }
                Console.Write("sum [{0}] : {1}\t", i, sum);
            }
        }


    }
}
