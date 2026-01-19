using Data_Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Abstraction
{
    abstract class Vehicle
    {
        public abstract void Start();
        public void FuelType()
        {
            Console.WriteLine("it use pertrol ");
        }
    }
}
class Car : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("car starts by using key");
    }
}