//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

using System;

class RandomizeNumbersToN
{
    static void Main()
    {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbArray = new int[n];
        bool[] isPrinted = new bool[n + 1];
        Random r = new Random();
        int random = r.Next(1, n + 1);

        for (int i = 0; i < n; i++)
        {
            random = r.Next(1, n + 1);
            if (!isPrinted[random])
            {
                Console.Write("{0} ", random);
                isPrinted[random] = true;
            }
            else
            {
                i--;
            }
        }
        Console.WriteLine();
    }
}

