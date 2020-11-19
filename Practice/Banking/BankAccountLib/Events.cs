using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountLib
{
    class Messages
    {
        Accounts account;
        public static void NotifyBalanceChanged(Object e,EventArgs args) {
            Console.WriteLine("SMS sent");
        }

        public void subscribeEvent( Accounts a) {
            account = a;
            account.BalanceChanged.BalanceChangedEventHandler += NotifyBalanceChanged;
        }
    }
}
