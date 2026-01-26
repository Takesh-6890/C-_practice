using System;
using System.Collections.Generic;
using Employees_LINQ_1;
namespace Employees_LINQ_1
{
    class Program
    {
        static void Main()
        {
            List<Employees> emps = new List<Employees>()
            {
                new Employees{id=1,name="takesh",salary=50000},
                new Employees{id=2,name="tanvas",salary=40000},
                new Employees{id=3,name="madhu",salary=60000},
                new Employees{id=4,name="suhail",salary=100000}


            };
            var highpaid = emps
                .Where(e => e.salary > 50000)
                .Select(e => e.name);
            foreach(var i in highpaid)
            {
                Console.WriteLine(i);
            }


        }
    }
}