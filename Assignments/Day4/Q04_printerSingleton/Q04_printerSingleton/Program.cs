using System;


namespace Q04_printerSingleton
{
    class Printer {
        static Printer p1;
        private Printer() { 
            
        }

        public static Printer getPrinter() {
            if (p1 == null)
                p1 = new Printer();
            return p1;
        } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            Printer pp1 = Printer.getPrinter();
            Printer pp2 = Printer.getPrinter();

            if (pp1.Equals(pp2))
                Console.WriteLine("same instance of printer");
            else
                Console.WriteLine("Different instances of printer");
        }
    }
}
