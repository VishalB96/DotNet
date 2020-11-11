using System;


namespace Q05_inheritance_polymophism
{
    public class Animal{
        public virtual void speak() {
            Console.WriteLine("I don’t know how to speak");
        }
    }
    public class Dog : Animal{
        public override void speak()
        {
            Console.WriteLine("BhowBho....");
        }
    }
    public class Cat : Animal{
        public override void speak() {
            Console.WriteLine("MewoMewo....");
        }
    }
    public class donkey : Animal { 
    
    }
    public class ShowPoly {


        public void PolyCall(Animal a1) {

            if (a1 is donkey)
                Console.WriteLine("Donkey cant speak...");
            else
             a1.speak();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ShowPoly p1 = new ShowPoly();
            p1.PolyCall(new Animal());
            p1.PolyCall(new Cat());
            p1.PolyCall(new Dog());
            p1.PolyCall(new donkey());
        }
    }
}
