using Employee_Management_Syatem.Models;
using Employee_Management_Syatem.Servives;
using Employee_Management_Syatem.Utils;
using EmployeeManagementSystem.Data;

using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagementSystem.Services
{
    public class EmployeeService : IEmployeesServise
    {
        private readonly Repository _repository;

        public EmployeeService()
        {
            _repository = new Repository();
        }

        public void AddEmployee(Employee employee)
        {
            _repository.Add(employee);
            Logger.Log($"Employee Added: {employee.Name}");
        }

        public void RemoveEmployee(int id)
        {
            var emp = GetEmployeeById(id);
            if (emp != null)
            {
                _repository.Remove(emp);
                Logger.Log($"Employee Removed: {emp.Name}");
            }
            else
            {
                throw new Exception("Employee not found");
            }
        }

        public List<Employee> GetEmployees()
        {
            return _repository.GetAll();
        }

        public Employee GetEmployeeById(int id)
        {
            return _repository.GetAll().FirstOrDefault(e => e.Id == id);
        }
    }
}
