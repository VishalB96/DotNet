using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountLib
{
    class BalanceChanged
    {
        public event EventHandler BalanceChangedEventHandler;

        public void onBalanceChanged() {
            if (BalanceChangedEventHandler != null)
                BalanceChangedEventHandler(this,EventArgs.Empty);
        }

    }
}
