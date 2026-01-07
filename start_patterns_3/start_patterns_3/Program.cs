using System;

public class StarPatterns3
{
    public static void Main(string[] args)
    {
        //hallowtraingle-right angled
        int n = 5;
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<=i;j++)
            {
                if( j==0 || j==i || i==n-1)
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



    }
}
