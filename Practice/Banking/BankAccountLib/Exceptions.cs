using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountLib
{
    public class InvalidAmt : Exception
    {
        public InvalidAmt() { }
    }
    public class MinBalNotMet : Exception
    {
        public MinBalNotMet() { }
    }
}
