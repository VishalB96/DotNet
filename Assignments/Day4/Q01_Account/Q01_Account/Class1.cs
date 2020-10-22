using System;


namespace Q01_Account
{
    public class Account
    {
        static int idA=12000;
        int id;
        string name;
        double bal_amount=0;

        public Account(string name)
        {
            this.id=++idA;
            this.name = name;
        }

        public void display() {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("ACC NO : {0}\nName : {1}\nBalance : {2}",id, name, bal_amount);
            Console.WriteLine("-------------------------------------------");
        }

        public void deposit(double amt) {
            this.bal_amount += amt;
            display();
        }

        public void withdraw(double amt) {
            if (bal_amount <= amt)
            {
                Console.WriteLine("insufficient balance");
            }
            else {
                bal_amount -= amt;
                display();
            }
        }

    }
}
