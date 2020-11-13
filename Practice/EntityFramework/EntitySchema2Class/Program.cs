using System;
using System.Collections.Generic;
using System.Linq;

namespace EntitySchema2Class
{
    class Program
    {
        static void addData() {
            MyDbEntities db = new MyDbEntities();
            product p = new product();
            Console.Write("Enter name of product : ");
            p.name = Console.ReadLine();
            Console.Write("Enter price of product : ");
            p.price = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter quantity : ");
            p.quantity = Convert.ToInt32(Console.ReadLine());

            db.products.Add(p);
            db.SaveChanges();
        }

        static void dispData() {
            MyDbEntities bd = new MyDbEntities();
            var rs = bd.products.ToList<product>();
            var rs1 = from rng in bd.products select rng;

            foreach (var result in rs1)
                Console.WriteLine("{0} {1} {2} {3}", result.Id, result.name, result.price, result.quantity);
        }
        static void Main(string[] args)
        {
            dispData();
            addData();
            dispData();
            
        }
    }
}
