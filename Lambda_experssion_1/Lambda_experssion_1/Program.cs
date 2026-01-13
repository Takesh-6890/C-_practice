/*lambda experssion
(a, b) => (a + b);

lambds with sinlge parameter
x=>x*x;
no paramerts
()=>Console.WriteLine("hello");

mltiple statements
(x,y)=>
{
int sum=x+y;
retutrn suml
}

*/


//func<>
using System;
class Program
{
    static void Main()
    {
        Func<int, int ,int> sum = (x, y) => x + y;
        Console.WriteLine(sum(20,5));

        Action<string>greet=person=> Console.WriteLine((("welcome" + person)));
        greet("takesh");

    }
}


