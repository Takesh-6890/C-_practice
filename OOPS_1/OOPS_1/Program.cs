using System;

namespace OOPS_1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Car ford = new Car();
            ford.model = "Mustang";
            ford.color = "Red";
            ford.speed = 200;
            ford.year = 2000;

            
            Car bmw = new Car("MARK 5", "Black", 650, 2005);

            Console.WriteLine(ford.ToString());
            Console.WriteLine(bmw.ToString());

            // Demonstrate static method
            Car.Power();
        }
    }
}


