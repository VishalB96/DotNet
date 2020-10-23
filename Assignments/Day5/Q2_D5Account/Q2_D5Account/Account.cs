using System;


namespace Q2_D5Account
{
    public class Account
    {
        const int maxAcc=2;
        const double minBal = 1000;
        static int getId;
        int id;
        string name;
        double balance;
        public Account(string name) {
            this.id = ++getId;
            if (id > maxAcc)
                throw new Exception("Maximum Accounts Reached");
            this.name = name;
            this.balance = minBal;
        }

        public void Deposit(double amt) {
            this.balance += amt;
            display();
        }

        public void Withdraw(double amt) {
            if (balance - amt <= minBal)
                Console.WriteLine("Amount cannot be withdraw in order to maintain minimum balance");
            else
                balance -= amt;
            display();
        }

        public void display() {
            Console.WriteLine("__________________________________________________________________________");
            Console.WriteLine("Id : {0}\nName : {1}\nBalance : {2}", id, name, balance);
            Console.WriteLine("__________________________________________________________________________");
        }

    }
}
