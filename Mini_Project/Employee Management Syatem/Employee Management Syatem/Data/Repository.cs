using Employee_Management_Syatem.Models;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EmployeeManagementSystem.Data
{
    public class Repository
    {
        private readonly string filePath = "employees.txt";
        private List<Employee> employees;

        public Repository()
        {
            
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close(); 
            }

            employees = LoadFromFile();
        }

        public void Add(Employee emp)
        {
            employees.Add(emp);
            SaveToFile();
        }

        public void Remove(Employee emp)
        {
            employees.Remove(emp);
            SaveToFile();
        }

        public List<Employee> GetAll()
        {
            return employees;
        }

        

        private void SaveToFile()
        {
            List<string> lines = new List<string>();

            foreach (var emp in employees)
            {
                
                lines.Add($"{emp.Id},{emp.Name},{emp.Department},{emp.Salary},{emp.JoiningDate}");
            }

            File.WriteAllLines(filePath, lines);
        }

        private List<Employee> LoadFromFile()
        {
            var list = new List<Employee>();
            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                var data = line.Split(',');

                list.Add(new Employee
                {
                    Id = int.Parse(data[0]),
                    Name = data[1],
                    Department = data[2],
                    Salary = double.Parse(data[3]),
                    JoiningDate = DateTime.Parse(data[4])
                });
            }

            return list;
        }
    }
}
