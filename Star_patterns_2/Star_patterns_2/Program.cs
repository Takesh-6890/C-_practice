using System;
public class StartPattern2
{
     static void Main(String[] args)
    {
        //hallow squre
        int n = 5;
        for (int i=0;i<n;i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == 0 || j == 0 || i == n - 1 || j == n - 1)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }

        //diamond

        Console.WriteLine();
        //upper triangle
        for(int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                Console.Write("  ");
            }
            for(int k=0;k<2*i+1;k++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
        //lower triangle
        for(int i=n-2;i>=0;i--)
        {
            for (int l =0;l<n-i-1;l++)
            {
                Console.Write("  ");
            }
            for(int k=0;k<2*i+1;k++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
        Console.ReadLine();

    }
}