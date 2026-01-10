using System;
public class Extra_patterns
{
    public static void Main()
    {
        int n = 5;
        //alphabet pattern
        for (int i=0;i<n;i++)
        {
            for(int j=0;j<=i;j++)
            {
                Console.Write((char)('A' + j) + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        //binary pattern
        for (int i=0;i<=n;i++)
        {
            for(int j=0;j<i;j++)
            {
                if((i+j)%2==0)
                {
                    Console.Write("1 ");
                }
                else
                {
                    Console.Write("0 ");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        //right side right aligined star pattern
        for(int i=1;i<=n;i++)
        {
            for(int s=1;s<=(2*n-i);s++)
            {
                Console.Write("  ");
            }
            for(int j=1;j<=i;j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
            
        }


        //right side half daimond

        for(int i=1;i<=n;i++)
        {
            for (int j=1;j<=i;j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
        for(int i=n-1;i>=1;i--)
        {
            for(int j=1;j<=i;j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}