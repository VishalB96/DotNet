using System;
using System.Collections.Generic;


namespace AccountsEvent
{
    class Message
    {
        Accounts a1; 
        public static void MessageSend(Object a, EventArgs args) {
            Console.WriteLine("SMS SENT");
        }

        public void subscribeEvent(Accounts acc) {
            a1 = acc;
            a1.balanceChanged.BalanceChange += new EventHandler(MessageSend);
        }
    }
}
