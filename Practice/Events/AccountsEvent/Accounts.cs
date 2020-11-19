using System;


namespace AccountsEvent
{
   abstract class Accounts
    {
        public BalanceChangeEvents balanceChanged;

        public Accounts() {
            balanceChanged = new BalanceChangeEvents();
        }
        public string Name { get; set; }
        public double Balance { get; set; }

        public string AccType { get; set; }

        public void dispBalance() {
            Console.WriteLine("{2}\n{0} : {1}",Name,Balance,AccType);
            
        }

        public void subEvent() {
            new Message().subscribeEvent(this);
        }

        

        public void withdraw(double amt) {
            Balance = Balance - amt;
            balanceChanged.onBalanceChanged();
            dispBalance();
        }

        public void deposit(double amt) {
            Balance = Balance + amt;
            balanceChanged.onBalanceChanged();
            dispBalance();
        }

    }

    class Savings : Accounts {
        public Savings(string name, double balance) {
            AccType = "Savings";
            Name = name;
            Balance = balance;
            dispBalance();
        }
    }


}
