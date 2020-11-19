using System;


namespace AccountsEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            Savings s1 = new Savings ( "Name1", 9000 );
            s1.dispBalance();
            s1.withdraw(400);
            s1.deposit(300);
            s1.subEvent();
            s1.withdraw(100);
        }
    }
}
