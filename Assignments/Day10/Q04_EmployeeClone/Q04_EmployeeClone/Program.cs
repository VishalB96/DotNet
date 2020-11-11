using System;
//Q4. Create a class employee having member name and salary, 
//    it has reference of address class which display location name[eg. vile-parle] 
//    Create a duplicate object using clone method

namespace Q04_EmployeeClone
{
    class Address:ICloneable {
        public string Location { get; set; }
        public Object Clone() {
            return this.MemberwiseClone();
        }
    }
    class Employee : ICloneable {
       public Address ad;
        public Employee() {
            ad=new Address{Location="Virar"};
        }
        public string Name{get;set;}
        public double Salary { get; set; }
        public Object Clone() {
            Employee nEmp = (Employee)MemberwiseClone();
            nEmp.ad = (Address)this.ad.Clone();
            return nEmp;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee { Name = "name1", Salary = 20000 };
            Employee e2 = (Employee)e1.Clone();
            Console.WriteLine(e1.ad.Location);
            Console.WriteLine(e2.ad.Location);
            e2.ad.Location = "Vasai";

            Console.WriteLine(e1.ad.Location);
            Console.WriteLine(e2.ad.Location);

        }
    }
}
