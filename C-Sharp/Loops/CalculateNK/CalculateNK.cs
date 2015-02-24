//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop

using System;

class CalculateNK
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());

        double sum = 1;
        if (1 < k && k < n && n < 100)
        {
            for (int i = 1 + k; i <= n; i++)
            {
                sum *= i;
            }
        }
        else
        {
            Console.WriteLine("Invalid case!");
        }
        Console.WriteLine(sum);
    }
}
