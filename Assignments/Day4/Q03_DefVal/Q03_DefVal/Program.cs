using System;
/*Q3. Create a class customer having member Id, name, billamount.
 * When you create a object allow to have default vale. 
Print default value of id,name, billamount.*/

namespace Q03_DefVal
{
    class Customer {
        int id;
        string name;
        double billAmount;
        public void display() {
            Console.WriteLine("id : {0}\nname : {1}\nBill amount : {2}", id, name, billAmount);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.display();
        }
    }
}
