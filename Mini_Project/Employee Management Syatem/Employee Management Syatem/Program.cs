using Employee_Management_Syatem.Models;
using Employee_Management_Syatem.Servives;
using EmployeeManagementSystem.Services;
using System;
using System.Threading.Channels;

namespace Employee_Management_Syatem
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployeesServise service = new EmployeeService();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\n------Employee Management System");
                Console.WriteLine("1.Addd employee");
                Console.WriteLine("2.view employee");
                Console.WriteLine("3.remove employee");
                Console.WriteLine("4.exit");
                Console.Write("choose option: ");

                int choice = int.Parse(Console.ReadLine());
                try
                {
                    switch (choice)
                    {
                        case 1:
                            AddEmployee(service);
                            break;
                        case 2:
                            ViewEmployee(service);
                            break;
                        case 3:
                            RemoveEmployee(service);
                            break;
                        case 4:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("invaild choice");
                            break;


                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"error :{ex.Message.ToString()}");
                }
            }
        }
        static void AddEmployee(IEmployeesServise service)
        {
            Console.Write("Id");
            int id = int.Parse(Console.ReadLine());
            Console.Write("name");
            string name = Console.ReadLine();
            Console.Write("Depertment");
            string dept = Console.ReadLine();
            Console.Write("salary");
            double slary = double.Parse(Console.ReadLine());
            Employee emp = new Employee
            {
                Id = id,
                Name = name,
                Department = dept,
                Salary = slary,
                JoiningDate = DateTime.Now
            };
            service.AddEmployee(emp);
            Console.WriteLine("\n---employee added done");

        }
        static void ViewEmployee(IEmployeesServise service)
        {
            var employee = service.GetEmployees();
            Console.WriteLine("\n--employee List");
            foreach (var emp in employee)
            {
                Console.WriteLine($"ID:{emp.Id} , name{emp.Name},dept{emp.Department},salary{emp.CalculateSlary()}");
            }
        }
        static void RemoveEmployee(IEmployeesServise service)
        {
            Console.WriteLine("enter the employee id to remove");
            int id=int.Parse(Console.ReadLine());
            service.RemoveEmployee(id);
            Console.WriteLine("employee removed");
        }
        
    }
}