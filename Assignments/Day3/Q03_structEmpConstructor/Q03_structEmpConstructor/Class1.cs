using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q03_structEmpConstructor
{
    public struct emp
    {
        string name;
        double salary;
        public emp(string name, double salary) {
            this.name = name;
            this.salary = salary;
        }
        public void dispEmp(){
            Console.WriteLine("Employee Name : {0}\nEmployee Salary : {1}",name,salary);
        }
    }
}
