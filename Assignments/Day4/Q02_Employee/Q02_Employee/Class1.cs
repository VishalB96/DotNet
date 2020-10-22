using System;


namespace Q02_Employee
{
    public class Employee
    {
        static int idA =100;
        int id;
        string name;
        double salary, net_salary;

        public Employee(string name, double salary) {
            this.name = name;
            this.salary = salary;
            CalNetSalary();
        }

        void CalNetSalary() {
            net_salary = salary - (salary * 0.1);
        }

        public void display() {
            Console.WriteLine("Name : {0}\nsalary : {1}\nNetSalary : {2}", name, salary, net_salary);
        }

    }
}
