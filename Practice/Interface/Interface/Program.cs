using System;
namespace InterfaceDemo
{    //default it is internal
    interface ImessageService
    {       //by default it is public
        void SendMessage(string address);
    }
    class parent
    {
        public void SendMessage(string address)
        { Console.WriteLine("parent send message"); }
    }
    class Email : parent, ImessageService
    {
         void sendmessage(string address)
        {
            Console.WriteLine("sending email to {0}", address);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Email eobj = new Email();
            eobj.SendMessage("DBDA");
            eobj.SendMessage("pp");
        }
    }
}

