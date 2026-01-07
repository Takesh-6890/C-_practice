using System;
public class WhileLoops
{
    public static void Main(string[] args)
    {
        /*nt i = 0;
         while(i<10)
         {
             Console.WriteLine(i);
             i++;
         }*/
        /*
        int i = 1;
        while (i < 10)
        {
            i++;
            Console.WriteLine(i);
        }

        */
        /*int i = 0;
        do
        {
            
            Console.WriteLine(i);
            i++;

        } while (i< 10);*/
        /*Console.WriteLine("enter your name");
        string n = Console.ReadLine();
        */
        //while

        /*while (n!="takesh")
        {
            Console.WriteLine("enter correct user name");
            n= Console.ReadLine();
         
                
        }
        Console.WriteLine("correct");*/



        //do-while
        string n;
        do
        {
            Console.WriteLine("enter your name");
            n=Console.ReadLine();
            if (n == "takesh")
            {
                Console.WriteLine("correct");
            }
            else
            {
                Console.WriteLine("incorrect");

            }
        } while (n != "takesh");






















        Console.ReadLine();
    }
}