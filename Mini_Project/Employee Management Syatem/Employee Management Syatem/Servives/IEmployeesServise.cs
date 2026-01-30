using System;
using System.Collections.Generic;
using System.Text;
using Employee_Management_Syatem.Models;

namespace Employee_Management_Syatem.Servives
{
    public interface IEmployeesServise
    {
        void AddEmployee(Employee employee);
        void RemoveEmployee(int id);
        List<Employee> GetEmployees();
        Employee GetEmployeeById(int id);
    }
}
