using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
             //Q1

             Console.WriteLine("enter the day in week");
             int day = Convert.ToInt32(Console.ReadLine());
             switch (day)
             {
                 case 1:
                     Console.WriteLine("mon");
                     break;
                 case 2:
                     Console.WriteLine("tue");
                     break;
                 case 3:
                     Console.WriteLine("wed");
                     break;
                 case 4:
                     Console.WriteLine("thur");
                     break;
                 case 5:
                     Console.WriteLine("fri");
                     break;
                 case 6:
                     Console.WriteLine("sat");
                     break;
                 case 7:
                     Console.WriteLine("sun");
                     break;
                 default:
                     Console.WriteLine("invalid");
                     break;

             }
            //Q2
            Console.Write("enter the number to show in readable");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:Console.Write("one");
                    break;
                case 2:Console.Write("two");
                    break;
                case 3:Console.Write("three");
                    break;
                case 4:Console.Write("four");
                    break;
                case 5:Console.Write("five");
                    break;
                default:
                    Console.WriteLine("invaild digit");
                    break;
            }
            

            //Q3
            Console.WriteLine("enter a alphabet to chech weather its a vowel or consonent");
            char alphabet = Convert.ToChar(Console.ReadLine());
            switch (alphabet)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("its vowel");
                    break;
                default:
                    Console.WriteLine("consonent");
                    break;
            }





            Console.ReadLine();
        }
    }
}
