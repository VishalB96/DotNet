using System;


namespace AccountsEvent
{
    
    class BalanceChangeEvents
    {
        public event EventHandler BalanceChange;

        public void onBalanceChanged() {
            Console.WriteLine("Balance Changed");
            if (BalanceChange != null)
                BalanceChange(this,EventArgs.Empty);
        }

        //public EventHandler EventHandlerC { get { return onBalanceChange; } }
    }
}
