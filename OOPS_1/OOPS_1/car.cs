using System;

namespace OOPS_1
{
    class Car
    {
        public string model;
        public string color;
        public int speed;
        public int year;

        
        public Car()
        {
            model = "Unknown";
            color = "Unspecified";
            speed = 0;
            year = 0;
        }

        // Parameterized constructor
        public Car(string model, string color, int speed, int year)
        {
            this.model = model;
            this.color = color;
            this.speed = speed;
            this.year = year;
        }

        public static void Power()
        {
            Console.WriteLine("it is speedy");
        }

        public override string ToString()
        {
            return $"{model} ({color}) - {speed} km/h - {year}";
        }
    }
}

