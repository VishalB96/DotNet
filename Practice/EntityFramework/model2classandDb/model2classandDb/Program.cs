using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model2classandDb
{
    class Program
    {
        static void Main(string[] args)
        {

            Model_empContainer mec = new Model_empContainer();
            var res = mec.EmpDemoes.ToList<EmpDemo>();
            foreach(var e in res)
                Console.WriteLine("{0} {1} {2} {3} {4}",
                    
                       e.Id,e.Name,e.Position,e.Salary,e.DeptDemoId);
            var res1 = from emp in res where int.Parse(emp.Salary) > 30000 select emp;
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++");
            foreach(var e in res1)
                Console.WriteLine("{0} {1} {2} {3} {4}",

                       e.Id, e.Name, e.Position, e.Salary, e.DeptDemoId);

            var res2 = from emp in res orderby emp.DeptDemoId select emp;
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++");
            foreach (var e in res2)
                Console.WriteLine("{0} {1} {2} {3} {4}",

                       e.Id, e.Name, e.Position, e.Salary, e.DeptDemoId);
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++");
            var res3 = from emp in mec.EmpDemoes
                       group emp by emp.DeptDemoId
                       ;
            foreach (var e in res3) {
                Console.WriteLine(e.Key);
                foreach(var ee in e)
                    Console.WriteLine("{0} {1} {2} {3} {4}",
                       ee.Id, ee.Name, ee.Position, ee.Salary, ee.DeptDemoId);
            
            }

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++");
            var res4 = from emp in mec.EmpDemoes
                       group emp by emp.DeptDemoId into empgrp
                       where empgrp.Count() >= 2
                       orderby empgrp.Key
                       select empgrp;

            foreach (var e in res4)
            {
                Console.WriteLine("{0}", e.Key);
                foreach(var eg in e)
                    Console.WriteLine("{0} {1} {2} {3} {4}",eg.DeptDemoId,eg.Name,eg.Position,eg.Salary,eg.Id);
            }

        }
    }
}
