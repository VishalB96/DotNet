using System;
//3. create class  Employee having member id, name, salary. Id should be autoincrement.
//Write getter setter for name and salary. Write abstract method givebonus.
//Create two child class Permanente employee and temporary employee. 
//    Create array of employee class store two object of class Permanente employee and temporary employee. 
//        As soon as you call givebonus it should send message stating total salary ,bonus and name. 


namespace Q03_Emp
{
    delegate void MyEventHandler();
    class myEvent{
    public event MyEventHandler ms;
    public void onBonus(){
            if (ms != null)
                ms();
        }
    }
    abstract class Employee {
        static int getId = 100;
        public string Name { get; set; }
        public int Id { set; get; }
        public double Salary { get; set; }
        public myEvent ev1;
        

        public Employee() {
            Id = ++getId;
        }
        public void msg() {
            Console.WriteLine("{0} {1} {2} Bonus assigned",Id,Name,Salary);
        }

       abstract public void giveBonus();

        public string toString() {
            return String.Format("{0} {1} {2} ", Id, Name, Salary);
        }

        
    }

    class PermenantEmp:Employee {
        public override void giveBonus() {
            Salary= Salary + (Salary * 0.2);
            
            ev1.onBonus();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new PermenantEmp() {Name="Name1",Salary=90000 };
            
            Console.WriteLine(e1);
            e1.ev1.ms += e1.msg;
            e1.giveBonus();


        }
    }
}
