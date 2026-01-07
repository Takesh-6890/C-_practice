using System;
using System.Globalization;
class Program
{
    public static void Main(string[] args)
    {
        double n = 12.13443535434253D;
        double x = 1213443535434.253D;
        double g = 0.85;
        long num = 987654321;
        Console.WriteLine(n.ToString("F5"));
        Console.WriteLine($"{n:F}");
        Console.WriteLine(String.Format("{0:F}", n));
        Console.WriteLine(n.ToString("F3"));
        Console.WriteLine(x.ToString("N1"));
        Console.WriteLine(x.ToString("C"));//? it means ruppe sybmol
        Console.WriteLine(x.ToString("C",new CultureInfo("en-US")));
        Console.WriteLine(g.ToString("P"));
        //Console.WriteLine(n.ToString("D5"));
        Console.WriteLine(n.ToString("00"));
        Console.WriteLine(n.ToString("0000.00"));
        Console.WriteLine(num.ToString("(###)###-####"));
        Console.WriteLine(n.ToString("+#;-#;0"));




    }
    
}