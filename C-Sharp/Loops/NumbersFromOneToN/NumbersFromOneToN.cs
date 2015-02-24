using System;

class NumbersFromOneToN
{
    static void Main()
    {
        Console.WriteLine("Enter number");
        int num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= num; i++ )
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("End");
    }
}

