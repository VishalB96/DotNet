using System;


namespace Q3_D5Employee
{
    public class MaxEmpReached : Exception {
        public MaxEmpReached(string message) { 
        }
    }

    public class MaxSalExceed : Exception {
        public MaxSalExceed() { }
    }
    public class Employee
    {
        const int maxemp = 3;
        const double maxsal = 50000;
        static double TDS = 0.1;
        static int getId;
        int id;
        string name;
        double salary, netsalary;

        

        public static void decGetId(){
            getId--;
        }
        public Employee(string name, double sal) {
            id = ++getId;
            if (getId > maxemp)
            {
                throw new MaxEmpReached("Max Employees reached");
            }
            this.name = name;
            if (sal > maxsal)
                throw new MaxSalExceed();
            this.salary=sal;
            calNetSal();
        }

        void calNetSal() {
            this.netsalary = salary - (salary * TDS);
        }

        public void disp() {
            Console.WriteLine("Name : {0}\nNetSalary : {1}", name, netsalary);
        }

    }
}
