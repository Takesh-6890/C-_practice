using System;


//method overloadind using params
class Mathops
{
    public int Add(params int[] numbers)
    {
        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }
        return sum;
    }

    static void Main()
    {
        Mathops m = new Mathops();
        Console.WriteLine(m.Add(1, 3, 4));
    }
}
