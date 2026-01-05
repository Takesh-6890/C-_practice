using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forloops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("enter the word want to repeat ");
             string word = Console.ReadLine();
             Console.WriteLine("how many times you want to repeat the word");
             int times = Convert.ToInt32(Console.ReadLine());
             if (times<=0)
             {
                 Console.WriteLine("enter above 0 ");
             }
             else
             {
                 for (int i = 1; i <= times; i++)
                 {
                     Console.WriteLine(word);
                 }

             }*/

            //STAR pattern
            Console.WriteLine("enter the number for star pattern");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("* ");
                Console.WriteLine();
            }
            int n = 5;
            for (int i=n;i>=1;i--)
            {
                for (int j =1;j<=i;j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            int n = 5;

            for (int i = 1; i <= n; i++)
            {

                for (int s = 1; s <= n - i; s++)
                {
                    Console.Write("  ");
                }

                for (int j = 1; j <= (2 * i - 1); j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            int n = 5;
            for (int i =n;i>=1;i--)
            {
                for(int s=1;s<=n-i;s++)
                {
                    Console.Write("  ");
                }
                for(int j =1;j<=(2*i-1);j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

        }
    }
}
