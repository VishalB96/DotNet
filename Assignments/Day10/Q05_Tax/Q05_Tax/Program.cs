using System;
using System.Collections;
//Q5. Create a interface Itaxtogov with method void paytax(double amt) create a class myindia,
//    myeurope let this class implement this interface.
//    In class myindia  paytax method will print tax amount which is 40% of the data passed in method. 
//    In class myeurope  paytax method will print tax amount which is 30% of the data passed in method.

namespace Q05_Tax
{
    interface Itaxtogov {
        void paytax(double amt);
    }
    class MyIndia:Itaxtogov {

        public void paytax(double amt) {

            Console.WriteLine("Tax in india : {0}",amt - (amt * 0.4));
        }
    }
    class MyEurope : Itaxtogov {

        public void paytax(double amt) {
            Console.WriteLine("Tax in europe : {0}",amt-(amt*0.3));
        }
    
    }
    class Program
    {
        static void Main(string[] args)
        {
            new MyIndia().paytax(10000);
            new MyEurope().paytax(10000);
            
        }
    }
}
