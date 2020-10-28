using System;
using Q1_Account_getSetPropertyLib;

namespace Q05_AccountArrayofObjects
{
    class Program
    {
        static  Program(){
        Console.WriteLine("VBank LTD.\n\n\n");
        }

        public static Account createAccount()
        {
            Account a1 = null;
            Console.Write("Enter name and balance\nName : ");

            string name = Console.ReadLine();

            Console.Write("Balance : ");
            double amt;
            if (double.TryParse(Console.ReadLine(), out amt))
                try
                {
                    a1 = new Account(name, amt);
                }
                catch (MinBalNotMet)
                {
                    Account.decGetId();
                    Console.WriteLine("Minimum balance should be Rs1000\nDo you want to try again?Y/N");
                    char ch = char.Parse(Console.ReadLine());
                    switch (ch)
                    {
                        case 'y':
                        case 'Y':
                            a1 = createAccount();
                            return a1;
                        case 'n':
                        case 'N':
                            return a1;
                        default:
                            Console.WriteLine("invalid choice going back a step....");
                            return a1;
                    }
                }
                catch (Exception)
                {
                    Account.decGetId();
                    Console.WriteLine("Name cannot be empty try again");
                    a1 = createAccount();
                    return a1;
                }

            else
            {
                Console.WriteLine("Amount can only be numeric");
                a1 = createAccount();
                return a1;
            }
            return a1;
        }

        static void Main(string[] args)
        {
            Account[] accs = new Account[3];
            for(int i=0;i<3;i++){
                accs[i] = createAccount();
            }

            for (int i = 0; i < 3; i++)
            {
                try
                {
                    Console.WriteLine("Account info : ");
                    accs[i].display();
                    Console.WriteLine("\nEnter amount to deposit");
                    double amt = double.Parse(Console.ReadLine());
                    accs[i].Deposit(amt);
                    Console.WriteLine("\nEnter amount to withdraw");
                    amt = double.Parse(Console.ReadLine());
                    accs[i].withdraw(amt);
                }
                catch (InvalidAmt)
                {
                    Console.WriteLine("Amount cant be -Ve or Zero");
                }
                catch (MinBalNotMet)
                {
                    Console.WriteLine("Minimum balance of Rs 1000 should met.");
                }
            }


        }
    }
}
