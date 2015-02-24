using System;
using System.Numerics;
//Write a program to calculate the n-th Catalan number by given n (1 < n < 100).

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Enter long you want Catalan number:");
        int n = int.Parse(Console.ReadLine());

        BigInteger factorial = 1;
        BigInteger divideFactorial = 1;

        if (n < 0)
        {
            Console.WriteLine("Enter positive number under 100!");
            return;
        }
        if (n < 100)
        {
            for (int i = 2 * n; i > n + 1; i--)    
            {
                factorial *= i;
            }
            for (int i = 1; i <= n; i++)           
            {
                divideFactorial *= i;
            }
            BigInteger sum = factorial / divideFactorial;   
            Console.WriteLine("n = {0} is: {1}", n, sum);
        }
        else
        {
            Console.WriteLine("Too long :)");
        }
    }
}

