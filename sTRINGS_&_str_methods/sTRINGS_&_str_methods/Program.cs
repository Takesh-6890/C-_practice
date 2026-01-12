//String and its methods

using System;
using System.Text;
class Strings
{
    static void Main(string[] args)
    {
        string name = "takesh";
        Console.WriteLine(name[3]);

        Console.WriteLine(name.Length);

        Console.WriteLine(name.ToUpper());
        Console.WriteLine(name.ToLower());

        string hello = "   tak  ";
        Console.WriteLine(hello.Trim());

        Console.WriteLine(name.Substring(0,4));

        Console.WriteLine(name.Contains("s"));

        Console.WriteLine(name.Replace("takesh","tanvas"));


        string first = "C# is used in >NET";
        string[] words = first.Split('@');
        Console.WriteLine(string.Join(", ", words));
        /* name.EndsWith("char of the the name")
         * name.StartsWith("char") 
         * */


        Console.WriteLine(name.IndexOf('a'));


        //String Concatination methods

        string name1 = "j";
        string name2 = "takesh";
        Console.WriteLine(name1+" "+name2);

        Console.WriteLine(string.Concat("takesh","tanvas"));
        //interpolation
        string greet = $"hello {name2}";
        Console.WriteLine(greet);



        //stringbuilder

        StringBuilder full_name = new StringBuilder();

       
        full_name.Append("takesh");
        full_name.Append(" tanvas");

        Console.WriteLine(full_name.ToString());


        //stringbuilder methods
        //full_name.EnsureCapacity(100);

        full_name.AppendLine("jangita");

        full_name.Insert(5, "c#");

        //.Remove(0,5)

        //.Replace("takesh","tanvas")

        //.Clear();

        //.Length();
        int cap= full_name.Capacity;
        Console.WriteLine(cap);
    }
}