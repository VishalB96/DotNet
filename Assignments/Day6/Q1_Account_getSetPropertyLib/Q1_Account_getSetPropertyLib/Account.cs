using System;


namespace Q1_Account_getSetPropertyLib
{
    public class InvalidAmt:Exception{
        public InvalidAmt(){}
    }
    public class MinBalNotMet : Exception {
        public MinBalNotMet() { }
    }
    public class Account
    {
        static int getId;
        readonly int _id;
        static double minBalance = 1000;
        static float interestRate =(float)0.07;
        double _balance;
        string _name;
        /*para-Constructore */
        public Account(string name, double amt) {
            _id = ++getId;
            Name = name;
            if (amt < minBalance)
                throw new MinBalNotMet();
            else
                Balance = amt;
        }
        public static void decGetId() {
            getId--;
        }
        /*property name*/
        public string Name
        {
            set{
                if (value.Length!=0)
                    _name = value;
                else throw new Exception();
            }
            get { return _name; }
        }
        /*property balance*/
        public double Balance
        {
           protected set { _balance = value; }
            get { return _balance; }
        }
        /*readonly property ID*/
        public int ID {
            get {
                return _id;
            }
        }

        /*REad only property : Interest*/
        public double Interest {
            get {
                return Balance * interestRate;
            }
        }

        /*Method to display id,name,balance and interest*/
        public void display() {
            Console.WriteLine("ID : {0}\nName : {1}\nBalance : {2}\nInterest : {3}", ID, Name, Balance,Interest);
        }

        /*Method for withrawal*/
        public void withdraw(double amt){

            if (amt <= 0)//if amt is -ve or 0
                throw new InvalidAmt();
            if (_balance - amt < minBalance)//if after withrawal bal is less than minBalance
                throw new MinBalNotMet();
            Balance = Balance - amt;//deduction from bal
            display();//display method call
            
        }
        /*Method to deposit */
        public void Deposit(double amt) {
            if (amt <= 0)//id amt is -ve or 0
                throw new InvalidAmt();
            else 
                Balance = Balance + amt;//deposit
            display();//display method call
        }
    }
}
