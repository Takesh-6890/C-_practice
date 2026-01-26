using System;
using Employees_payRoll_LINQ_2;
using System.Collections.Generic;
using System.Text;
namespace Employees_payRoll_LINQ_2
{
    class Program
    {
        static void Main()
        {
            List<Employyes> emp = new List<Employyes>
            {
                new Employyes{id=1,name="takesh",dept="IT",salary=100000},
                 new Employyes { id = 2, name = "Ravi", dept = "HR", salary = 60000 },
            new Employyes { id = 3, name = "Neha", dept = "IT", salary = 80000 },
            new Employyes { id = 4, name = "Pooja", dept = "HR", salary = 60000 },
            new Employyes { id = 5, name = "Karan", dept = "Finance", salary = 90000 }
            };

            var highpaid = emp.Where(e => e.salary > 60000).OrderByDescending(e => e.salary).ThenBy(e => e.name);
            Console.WriteLine("highest paid employee");

            foreach (var e in highpaid)
            {
                Console.WriteLine($"{e.name}--{e.salary}");
            }

            int totalemp=emp.Count();
            int maxsalary = emp.Max(e => e.salary);
            double avgsalary=emp.Average(e=>e.salary);

            Console.WriteLine("stats");
            Console.WriteLine($"total employees : { totalemp}");
            Console.WriteLine($"maximum salary : { maxsalary}");
            Console.WriteLine($"average salary : { avgsalary}");
        }

    }
}