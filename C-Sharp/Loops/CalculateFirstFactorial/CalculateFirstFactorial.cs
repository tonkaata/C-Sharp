using System;

class CalculateFirstFactorial
{
    static void Main()
    {
        Console.Write("Write n number =  ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Write x number =  ");
        double x = int.Parse(Console.ReadLine());
        double sum = 1;
        double factorialNumber = 1;
        double delNumber = 1.00;
        for (int i = 1; i <= n; i++)
        {
            factorialNumber *= i;
            delNumber *= x;
            sum += (factorialNumber / delNumber);
        }
        Console.WriteLine("Sum =  {0:f5}", sum);
    }
}
