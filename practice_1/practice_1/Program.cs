using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //question-1
            Console.WriteLine("enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("enter your age: ");

            string ageip = Console.ReadLine();
            int age = Convert.ToInt32(ageip);
            Console.Write("hello " + name + " you are " + age + " years old ");
            Console.WriteLine();
            //question-2
            Console.Write("enter the value a");

            string a = Console.ReadLine();
            Console.WriteLine();

            Console.Write("enter the value b");

            string b = Console.ReadLine();
            int c = Convert.ToInt32(a);
            int d = Convert.ToInt32(b);
            int e = c + d;
            int f = c - d;
            int g = c * d;
            int h = c / d;

            Console.WriteLine("the sum is" + e);
            Console.WriteLine("the diff is" + f);
            Console.WriteLine("the product is" + g);
            Console.WriteLine("the division is" + h);


            //question-3
            Console.WriteLine("enter your  Birth year");
            string DOB = Console.ReadLine();
            int dob = Convert.ToInt32(DOB);

            int CurrentYear = 2025;

            int age2 = CurrentYear - dob;

            Console.WriteLine("your age is  "+age2);










            Console.ReadLine();
        }
    }
}
