using System;
public class num_pattern
{
    public static void Main()
    {
        //number triangle pattern
        int n = 5;
        for(int i=1;i<=n;i++)
        {
            for (int j= 1;j <= i;j++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine();

        //Floyd's Triangle
        int num= 1;
        for (int i = 1; i <= n; i++)
        {
            for(int j = 1; j <= i; j++)
            {
                Console.Write(num + " ");
                num++;
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine();


        //inverted number triangle
        for(int i = n; i >= 0; i--)
        {
            for(int j = 1; j <= i; j++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        //next number triangle
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine();
        //inverted next number triangle;
        for(int i=n;i>=1;i--)
        {
            for(int j=1;j<=i;j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}