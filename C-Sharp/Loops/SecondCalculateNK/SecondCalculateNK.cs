//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.
using System;

class SecondCalculateNK
{
    static void Main()
    {
        Console.Write("Enter number n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter number k: ");
        int k = int.Parse(Console.ReadLine());
        double num = n - k;
        double sum = 1;
        double firstMultipl = 1;
        double secondMultiple = 1;
        
        if (1 < k && k < n && n < 100)
        {
            for (int i = 1 + k; i <= n; i++)
            {
                firstMultipl *= i;
            }
            for (int j = 1; j <= num; j++)
            {
                secondMultiple *= j;
            }
            sum = firstMultipl / secondMultiple;
        }
        else
        {
            Console.WriteLine("Incorrect Values!!");
        }
        Console.WriteLine(sum);
    }
}

