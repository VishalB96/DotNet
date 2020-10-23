using System;
using Q3_D5Employee;

namespace Q3_MainApp
{
    
    class Program
    {
        static Program() {
            Console.WriteLine("VSTech LTD\n\n");
        }
        static Employee createEmp() {
            
            Employee e1 = null;
            Console.Write("Enter name : ");
            string name = Console.ReadLine();
            Console.Write("Enter Salary : ");
            double sal;
            if (!(double.TryParse(Console.ReadLine(), out sal)))
            {
                Console.WriteLine("salary cannot be non numberic");
                createEmp();
            }
            try {
                e1 = new Employee(name, sal);
            }
            catch (MaxEmpReached)
            {
                Console.WriteLine("\nMaximum employee reached\n");
               return null;
            }
            catch (MaxSalExceed) {
                Console.WriteLine("\nMaximum salary exceeded!check & try again\n");
                Employee.decGetId();
                e1 = createEmp();
            }
            
            return e1;
        }
        
        static void Main(string[] args)
        {
            Employee e1 = createEmp();
            Console.WriteLine("\n");
            Employee e2 = createEmp();
            Console.WriteLine("\n");
            Employee e3 = createEmp();
            Console.WriteLine("\n");
            Employee e4 = createEmp();
            Console.WriteLine("\n");
            e1.disp();
            e2.disp();
            e3.disp();

        }
    }
}
