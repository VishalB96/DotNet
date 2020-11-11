// Create multiple threads of execution. 
using System;
using System.Threading;
using System.Data.SqlClient;

namespace threadingRightWay
{
    class MyThread
    {
        public int count;
        public Thread thrd;

        public MyThread(string name)
        {
            count = 0;
            thrd = new Thread(this.run);
            thrd.Name = name;
            thrd.Start();
        }

        // Entry point of thread. 
        void run()
        {
            Console.WriteLine(thrd.Name + " starting.");

            do
            {
                Thread.Sleep(500);
                Console.WriteLine("In " + thrd.Name +
                                  ", count is " + count);
                count++;
            } while (count < 10);

            Console.WriteLine(thrd.Name + " terminating.");
        }
    }
    class MoreThreads
    {
        public static void Main()
        {
            Console.WriteLine("Main thread starting.");

            // Construct three threads. 
            MyThread mt1 = new MyThread("Child #1");
            MyThread mt2 = new MyThread("Child #2");
            MyThread mt3 = new MyThread("Child #3");
            MyThread mt4 = new MyThread("Child #4");
            MyThread mt5 = new MyThread("Child #5");
            MyThread mt6 = new MyThread("Child #6");
            MyThread mt7 = new MyThread("Child #7");
            MyThread mt8 = new MyThread("Child #8");
            MyThread mt9 = new MyThread("Child #9");
            MyThread mt10 = new MyThread("Child #10");
            MyThread mt11= new MyThread("Child #11");
            MyThread mt12= new MyThread("Child #12");
            MyThread mt13= new MyThread("Child #13");
            MyThread mt14= new MyThread("Child #14");
            MyThread mt15= new MyThread("Child #15");
            MyThread mt16 = new MyThread("Child #16");
            MyThread mt17= new MyThread("Child #17");
            MyThread mt18= new MyThread("Child #18");
            MyThread mt19= new MyThread("Child #19");
            MyThread mt20= new MyThread("Child #20");
            MyThread mt21= new MyThread("Child #21");
            MyThread mt22= new MyThread("Child #22");
            MyThread mt23= new MyThread("Child #23");
            MyThread mt24= new MyThread("Child #24");
            MyThread mt25= new MyThread("Child #25");
            MyThread mt26= new MyThread("Child #26");
            MyThread mt27= new MyThread("Child #27");
            MyThread mt28= new MyThread("Child #28");
            MyThread mt29= new MyThread("Child #29");

            

            do
            {
                Console.Write(".");
                Thread.Sleep(100);
            } while (mt1.count < 10 ||
                     mt2.count < 10 ||
                     mt3.count < 10);

            Console.WriteLine("Main thread ending.");
        }
    }
}