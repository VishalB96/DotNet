using System;


namespace del1
{
    delegate void messenger (); 
   static class message {
       public static void sms() { Console.WriteLine("sms send"); }
       public static void email() { Console.WriteLine("Email send"); }
    }
   class emp {
       public string name { set; get; }
       public double salary { set;get; }
       public void disp(){
           Console.WriteLine("{0} {1}",name,salary);
           messenger m1 = message.sms;
           m1 += message.email;
           m1.Invoke();
       }
   }
    class Program
    {
        static void Main(string[] args)
        {
            new emp() { name = "name1", salary = 40000 }.disp();
        }
    }
}
