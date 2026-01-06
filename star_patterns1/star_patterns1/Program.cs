using System;
class StartPatterns1
{
    public static void Main(String[] args)
    {
        //right angle triangle
        int n = 5;
        for(int i=1;i<=n;i++)
        {
            for (int j=1;j<=i;j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();

        }

        Console.WriteLine();
        //inverted right angle
        for(int i=n;i>=1;i--)
        {
            for(int j=1;j<=i;j++)
            {
                Console.Write("* ");

            }
            Console.WriteLine();
        }
        //pyramid
        Console.WriteLine();
        for(int i =1;i <=n;i++)
        {
            for (int s=1;s<=n-i;s++)
            {
                Console.Write("  ");
            }
            for(int j=1;j<=(2*i-1);j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
        //inverted Pyramid
        Console.WriteLine();
        for(int i=n;i>=1;i--)
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
















        Console.ReadLine();
    }
}