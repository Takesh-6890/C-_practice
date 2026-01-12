// method overriding 
using System;
class Home
{
    public virtual void People()
    {
        Console.WriteLine("people live here");
    }

}
class Boy : Home
{
    public override void People() //we can user public sealed override void People(); , to stop the grand child heritance
    {
        Console.WriteLine("but i'm the creature");
    }
    
}
class Program
{
    static void Main()
    {
        Home a = new Boy();
        a.People();
    }
}



