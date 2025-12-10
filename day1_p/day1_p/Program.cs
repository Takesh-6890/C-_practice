using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1_p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello tanvas");
            // data_types
            int a = 20;
            Console.WriteLine(a);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            long num = 516548166L;
            Console.WriteLine(num);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

            double num2 = 55.2;
            Console.WriteLine(num2);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            float num3 = 215.4F;
            Console.WriteLine(num3);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);

            decimal mony = 44.9M;
            Console.WriteLine(mony);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);


            //aertimetic operations

            int x = 10,
                y = 20;
            int z = x + y;
            Console.WriteLine(z);
            float f = x - y;
            Console.WriteLine(f);
     
            int d = x / y;
            Console.WriteLine(d);

            // it goes *,-,+,/,//,%...etc

            //string and char

            string name = "tanvas";
            Console.WriteLine(name);
            char i = 'J';
            Console.WriteLine(i);
            //d/f methods to retive and print   
            Console.WriteLine("your name is "+name);
            Console.WriteLine($"your name is {name}");
            Console.WriteLine("your name is {0}",name);
            Console.Write("hi , how r u ");
            Console.Write(i);
           
           
            Console.ReadLine();

        }
    }
}
