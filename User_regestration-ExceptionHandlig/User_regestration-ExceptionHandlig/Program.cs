using System;

namespace User_regestration_ExceptionHandlig
{
    class Program
    {
        public static void Main()
        {
            try
            {
                Console.Write("Enter the name: ");
                string name = Console.ReadLine()?.Trim();
                if (string.IsNullOrEmpty(name))
                    throw new ArgumentException("Name can't be empty", nameof(name));

                Console.Write("Enter age: ");
                if (!int.TryParse(Console.ReadLine(), out int age))
                    throw new FormatException("Age must be a valid integer.");

                if (age < 18)
                    throw new AgeNotValidException("Age must be at least 18.");

                Console.Write("Enter your salary: ");
                if (!double.TryParse(Console.ReadLine(), out double salary))
                    throw new FormatException("Salary must be a valid number.");

                Console.WriteLine("\nRegistration done");
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Age: {age}");
                Console.WriteLine($"Salary: {salary:N2}");
            }
            catch (AgeNotValidException ex)
            {
                Console.WriteLine("Invalid age: " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Invalid input: " + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Enter valid format: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("\nClosing form safely");
            }
        }
    }
}