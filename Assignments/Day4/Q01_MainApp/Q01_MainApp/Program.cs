using System;
using Q01_Account;

namespace Q01_MainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name");
            Account a1 = new Account(Console.ReadLine());
            a1.display();
            Console.WriteLine("Enter Name");
            Account a2 = new Account(Console.ReadLine());
            a2.display();
            Console.Write("Deposite in acc 1 \nAmount : ");
            a1.deposit(double.Parse(Console.ReadLine()));
            Console.WriteLine("Withdraw from acc 1\nAmount : ");
            a1.withdraw(double.Parse(Console.ReadLine()));
            Console.Write("Deposite in acc 2 \nAmount : ");
            a2.deposit(double.Parse(Console.ReadLine()));
            Console.WriteLine("Withdraw from acc 2\nAmount : ");
            a2.withdraw(double.Parse(Console.ReadLine()));

            

        }
    }
}
