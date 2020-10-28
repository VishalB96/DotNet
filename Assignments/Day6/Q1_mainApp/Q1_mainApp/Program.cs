using System;
using Q1_Account_getSetPropertyLib;

namespace Q1_mainApp
{
    class Program
    {
        static Program() {
            Console.WriteLine("Welcome to VSBank.Ltd\n\n");
        }

        public static Account createAccount(){
            Account a1=null;
            Console.Write("Enter name and balance\nName : ");

            string name = Console.ReadLine();
            
            Console.Write("Balance : ");
            double amt;
            if (double.TryParse(Console.ReadLine(), out amt))
                try
                {
                    a1 = new Account(name, amt);
                }
                catch (MinBalNotMet) {
                    Account.decGetId();
                    Console.WriteLine("Minimum balance should be Rs1000\nDo you want to try again?Y/N");
                    char ch=char.Parse(Console.ReadLine());
                    switch (ch) { 
                        case 'y':
                        case 'Y':
                            a1=createAccount();
                            return a1;
                        case 'n':
                        case 'N':
                            return a1;
                        default:
                            Console.WriteLine("invalid choice going back a step....");
                            return a1;
                    }
                }
                catch(Exception){
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
            Account a2 = createAccount();
            a2.display();
            try
            {
                Console.WriteLine("Enter amount to deposit");
                double amt = double.Parse(Console.ReadLine());
                a2.Deposit(amt);
                
                Console.WriteLine("Enter amount to withdraw");
                amt = double.Parse(Console.ReadLine());
                a2.withdraw(amt);
            }
            catch (InvalidAmt)
            {
                Console.WriteLine("Amount cant be -Ve or Zero");
            }
            catch (MinBalNotMet) {
                Console.WriteLine("Minimum balance of Rs 1000 should met.");
            }
        }
    }
}
