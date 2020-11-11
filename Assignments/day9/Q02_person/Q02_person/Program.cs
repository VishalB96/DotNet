using System;


namespace Q02_person
{
    class Person {
        public virtual void DoJob() {
            Console.WriteLine("Doing job");
        }
    }
    class Programmer : Person {
        public override void DoJob()
        {
            Console.WriteLine("Coding");
        }
        public void Testing() {
            Console.WriteLine("Also Testing....");
        }
    }
    class Singer : Person {
        public override void DoJob()
        {
            Console.WriteLine("Singing");
        } 
    }
    class Dancer : Person { }
    class Program
    {
        static void PolyCall(Person p) {
            if (p is Dancer)
                Console.WriteLine("Dancer dont have dojob");
            else if (p is Programmer)
            {
                p.DoJob();
                ((Programmer)p).Testing();
            }
            else
                p.DoJob();
            
        }
        static void Main(string[] args)
        {
            Person[] pArray = new Person[4];
            pArray[0] = new Person();
            pArray[1] = new Programmer();
            pArray[2] = new Dancer();
            pArray[3] = new Singer();
            foreach (Person p in pArray) {
                PolyCall(p);
                Console.WriteLine("-------------------------------------------------------");
            }
        }
    }
}
