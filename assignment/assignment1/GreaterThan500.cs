
using System;

public class GreaterThan500
{
    static void Main2()
    {
        GreaterThan500 s = new GreaterThan500();
        s.Sum();
    }
    public void Sum()
    {
        int a, b, sum = 0;
        Console.Write("Enter number a: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number b: ");
        b = Convert.ToInt32(Console.ReadLine());

        sum = a + b;
        if (sum > 500)
        {
            Console.Write("true");
        }
        else
        {

            Console.Write("false");
        }

    }
}