//Write a program that enters 3 integers n, min and max (min != max) 
//and prints n random numbers in the range [min...max].

using System;

class RandomNumbers
{
    static void Main()
    {
        Console.Write("Enter n value: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter min value: ");
        int minValue = int.Parse(Console.ReadLine());

        Console.Write("Enter max value: ");
        int maxValue = int.Parse(Console.ReadLine());

        if (minValue != maxValue && minValue < maxValue)
        {
            Random r = new Random();
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} ", r.Next(minValue, maxValue + 1)); 
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("min != max");
        }
    }
}

