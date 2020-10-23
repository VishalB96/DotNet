using System;
using Q2_D5Account;

namespace Q02_mainApp
{
    class Program
    {
        static Program() { Console.WriteLine("VSTech LTD\n\n"); }
        static Account createAcc(){
            Account a1 = null;
            try
            {
                Console.Write("Enter name : ");
                string name1 = Console.ReadLine();
                 a1 = new Account(name1);
                a1.display();
            }
            catch (Exception )
            {
                Console.WriteLine("Maximim number of accounts reached!");
            }
            return a1;
        }

        static void depo(Account a){
            double amt;
            Console.Write("Enter amount to deposit : ");
            if (double.TryParse(Console.ReadLine(), out amt))
                a.Deposit(amt);
            else
            {
                Console.WriteLine("Invalid Input! Amount cant be non-numberic");
                depo(a);
            }
        }

        static void withd(Account a) {
            double amt;
            Console.Write("Enter Amount to be withdraw : ");
            if (double.TryParse(Console.ReadLine(), out amt))
                a.Withdraw(amt);
            else {
                Console.WriteLine("Invalid Input! Amount cant be non-numberic");
                withd(a);
            }

        }
        static void Main(string[] args)
        {
            Account acc1 = createAcc();
            Account acc2 = createAcc();
            Account acc3 = createAcc();

            int ch=0;
            do {
                
                Console.WriteLine("\nEnter Choice : ");
                Console.WriteLine("1.Deposit in acc1\n2.Withdraw from acc1\n3.Deposit in acc2\n4.Withdraw from acc2\n5.Exit");
                if (!(int.TryParse(Console.ReadLine(), out ch)))
                    ch = 6;
                switch (ch) {
                    case 1:
                        depo(acc1);
                        break;
                    case 2:
                        withd(acc1);
                        break;
                    case 3:
                        depo(acc2);
                        break;
                    case 4:
                        withd(acc2);
                        break;
                    case 5:
                        Console.WriteLine("Exiting.....");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            } while (ch != 5);
            
        }
    }
}
