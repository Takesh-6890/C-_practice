//Mehods and parameters in C#
using System;

/*static void hello()
{
    Console.WriteLine("hello world");

}
hello();

static void greet(string name)
{
    Console.WriteLine("hello "+name);    
}
greet("takesh");


static void add(int a, int b)
{
    Console.WriteLine(a+b);
}
add(5, 2);

static int multiply(int x, int y)
{
    return x*y;
}
int result= multiply(4, 3);
Console.WriteLine(result);

//types of paramerts
//value parameters

static void change(int x)
{
    x = 10;
}
int a = 5;
change(a);
Console.WriteLine(a);

//ref parameter 

static void reff(ref int x)
{
    x = 50;
}
int b = 10;
reff(ref b);
Console.WriteLine(b);

//out parameter

static void outt(out int x, out int y)
{
    x = 10;
    y = 20;

}
int c, d;
outt(out c, out d);
Console.WriteLine(c);
Console.WriteLine(d); 

//optional parameters

static void print(string  name="takesh")
{
    Console.WriteLine(name);
}
print();
print("tanvas");


//named parameters
static void show(string name, int e)
{
    Console.WriteLine(name+" "+e);
}
show(e: 20, name: "tanvas");

//params 
static int sum(params int[] numbers)
{
    int s = 0;
    foreach (int n in numbers)
    {
        s += n;
        
    }
    return s;
    
}
int output = sum(1, 2, 3, 4);
Console.WriteLine(output);

static void people(string title ,params string[] names )
{
    //Console.WriteLine(title); first argument become title 
    foreach(var name in names)
    {
        Console.WriteLine(name);

    }

}
people("takesh", "tanvas", "aliens");*/

//method overloading
class Calculator
{
    static int Add(int a, int b)
    {
        return a + b;
    }
    static int Add(int a, int b, int c)
    {
        return a + b + c;
    }
    static double Add(double a, double b)
    {
        return a + b;
    }
    static void Main()
    {
        Console.WriteLine(Add(1, 2));
        Console.WriteLine(Add(1, 2, 4));
        Console.WriteLine(Add(2.5, 5.6));

        // Run Mathops example
        Mathops m = new Mathops();
        Console.WriteLine(m.Daa(1, 3, 4));
    }

}


//method overloding with params

class Mathops
{
    public int Daa(params int[] numbers)
    {
        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }
        return sum;
    }
  

}



