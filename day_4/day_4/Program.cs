using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("enter a number to check weather its a positive or negitive");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine("its a negitive number");

            }
            else if (num > 0)
            {
                Console.WriteLine("is a positive number");

            }
            else
            {
                Console.WriteLine("its zero");
            }
            */


            
            Console.Write("enter a number to check weather its a even or odd: ");
            var num2 = Convert.ToInt32(Console.ReadLine());
            if (num2 % 2 == 0)
            {
                Console.Write("its an even number" + num2);

            }
            else
            {
                Console.Write("its a odd number" + num2);
            }
            */


            
            Console.WriteLine("enter a number1 ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a number2 ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num > num2)
            {
                Console.WriteLine($"{num} is greater");
            }
            else
            {
                Console.WriteLine($"{num2} is greater");
            }
             */
            
            Console.WriteLine("enter the 3 numbers to check which is bigger");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1>num2 && num1>num3)
            {
                Console.Write($"{num1} is greater");
            }
            else if (num2>num1 && num2>num3)
            {
                Console.Write($"{num2} is greater");
            }
            else 
            {
                Console.Write($"{num3} is greater");

            }
            */
            



                Console.ReadLine();
        }
    }
}
