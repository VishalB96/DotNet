using System;


namespace Q03_AnnonymousObj
{
    class Program
    {
        static void Main(string[] args)
        {
            var ob1 =new  { name = "Name1", salary = 54000 };
            var ob2 = new { name = "Name2", salary = 43000 };
            var ob3 = new { name = "Name3", salary = 87000 };
            var ob4 = new { name = "Name5", salary = 30000 };
            var ob5 = new { name = "Name4", salary = 60000 };

            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}", ob1, ob2, ob3, ob4, ob5);

        }
    }
}
