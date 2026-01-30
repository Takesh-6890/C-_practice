using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Management_Syatem.Models
{
    public enum UserRole
    {
        Admin,
        Manager,
        Employee,
    }
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }
    }
}