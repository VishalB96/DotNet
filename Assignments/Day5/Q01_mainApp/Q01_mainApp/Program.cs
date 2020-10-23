using System;
using Q1_Employee;


namespace Q01_mainApp
{
    class Program
    {
        static Program() { Console.WriteLine("VSTech LTD\n\n"); }
        static void Main(string[] args)
        {
            int ch;
            string fname, mname, lname;
            Employee e1;
            do {
                Console.Write("\nEnter Full name :\nFirst Name : ");
                fname = Console.ReadLine();
                Console.Write("Middle Name : ");
                mname = Console.ReadLine();
                Console.Write("Last Name : ");
                lname = Console.ReadLine();
               // Console.WriteLine("{0} {1} {2}", fname,mname, lname);
                if(mname==null)
                     e1 = new Employee(fname,mname,lname);
                else
                     e1 = new Employee(fname,lname);
                e1.disp();
                Console.WriteLine("Enter 0 to Exit else 1 to Continue...");
                ch=int.Parse(Console.ReadLine());
            } while (ch != 0);
        }
    }
}
