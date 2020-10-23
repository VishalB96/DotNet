using System;


namespace Q1_Employee
{
    public class Employee
    {
        string FirstName, LastName, MiddleName;
        public Employee(string fname, string mname, string lname) {
            this.FirstName = fname;
            this.MiddleName = mname;
            this.LastName = lname;
            Console.WriteLine("Const 3 para");
        }
        public Employee(string fname, string lname) {
            this.FirstName = fname;
            this.LastName = lname;
            Console.WriteLine("Const 2 para");
        }

        public void disp() {
            if (this.MiddleName != null)
                Console.WriteLine("Name : {0}_{1}_{2}", FirstName, MiddleName, LastName);
            else
                Console.WriteLine("Name : {0}_{1}", FirstName, LastName);
        }

    }
}
