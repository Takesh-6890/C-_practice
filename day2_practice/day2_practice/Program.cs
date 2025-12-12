using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //operators
            int a = 11;
            ++a;
            Console.WriteLine(a);
            a++;
            Console.WriteLine(a);
            --a;
            Console.WriteLine(a);
            a--;
            Console.WriteLine(a);
            Console.WriteLine(a++);
            Console.WriteLine(++a);
            double b = 5;
            b /= a;
            Console.WriteLine(b);
            int t = 2;
            t *= a;
            Console.WriteLine(t);
            String name = "Tanvas";
            Console.WriteLine(name+" is a dev" );
            // answer should be in unicode cahr A^~
            char ch = 'a';
            ch += 'b';
            Console.WriteLine(ch);

            char ch2 = 'a';
            ch = (char)(ch + 'b');
            Console.WriteLine(ch2);

            String name2 = "takesh";
            
            Console.WriteLine(name2 + name2);

            //reminder operation
            int num1 = 10;
            int num2 = 2;
            Console.WriteLine(num1 % num2);
            Console.WriteLine(90 % 71);
            //var keyword
            var f = 23;
            var g = 565658656564L;
            var h = 23.4D;
            var j = 57894.3M;
            var i = 4.6F;
            var surname = "jangita";
            var initial = 'j';
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);
            Console.WriteLine(j);
            Console.WriteLine(i);
            Console.WriteLine(surname);
            Console.WriteLine(initial);
            //const keyword
            const int vat = 20;
            //can not change 20 later 
            const String version = "v1.0";
            Console.WriteLine(version);
            Console.WriteLine(vat*(20));
            //ex-
            String name4 = "takesh";
            int number = 01250;
            int age = 25;

            var name5 = "takesh";
            //to store '0' we need to use string 
            var number2 = "01250";
            var age2 = 25;
            Console.WriteLine(name4);
            Console.WriteLine(name5);
            Console.WriteLine(number);
            Console.WriteLine(number2);
            Console.WriteLine(age);
            Console.WriteLine(age2);

            

            Console.ReadLine();
        }
    }
}
