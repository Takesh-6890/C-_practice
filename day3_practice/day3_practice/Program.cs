using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
//console ip/op

namespace day3_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter your name: ");
            Console.Write("enter your name ");
            string name = Console.ReadLine();
            Console.WriteLine("hello " + name);
            Console.Write("enter Your age : ");
            string age = Console.ReadLine();
            Console.WriteLine("your age is  " + age);

            Console.WriteLine("your name is " + name + " your age is " + age);
            Console.WriteLine();
            //methond-1(str to int)


            Console.Write("tera umardal idar ");

            string umardena = Console.ReadLine();  
            int umar = Convert.ToInt32(umardena);   
            Console.Write("tera umar hai " + umar);
            Console.WriteLine();

            //methon-2
            Console.Write("nee vayasu yanta ");
            int vayasu = Convert.ToInt32(Console.ReadLine());

            Console.Write("nee vayasu vachi " + vayasu);

            Console.ReadLine();
        }
    }
}
