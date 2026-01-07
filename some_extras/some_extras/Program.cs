using System;
public class extras
{
    public static void Main(string[] args)
    {

        //ternary operator
        Console.WriteLine("enter age below 19");
        int a = Convert.ToInt32(Console.ReadLine());
        //string result = a > 12  ? "teen" : "kid";
        //Console.WriteLine("result");
        //Console.WriteLine(a > 12 ? "teen" : "kid");

        //nested ternary
        string group = a < 19 ? "teen" :
            a < 13 ? "kid" :
            "adult";
        Console.WriteLine(group);
    }
}