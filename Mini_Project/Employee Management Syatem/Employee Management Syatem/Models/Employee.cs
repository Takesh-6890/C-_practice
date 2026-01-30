using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Management_Syatem.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
        public DateTime JoiningDate { get; set; }

        public virtual double CalculateSlary()
        {
            double tax = Salary * 0.10;
            return Salary - tax;
        }
    }
}
