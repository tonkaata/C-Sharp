using System;

class MinMaxSumAverageOfNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter your numbers count:");
        int n = int.Parse(Console.ReadLine());
        double number = 0;

        double minValue = double.MaxValue;
        double maxValue = double.MinValue;
        double sum = 0;

        for(int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter number {0}", i + 1);
            number = double.Parse(Console.ReadLine());
            if(number > maxValue)
            {
                maxValue = number;
            }
            if(number < minValue)
            {
                minValue = number;
            }
            sum += number;
        }
        Console.WriteLine("minvalue is:{0}", minValue);
        Console.WriteLine("maxvalue is:{0}", maxValue);
        Console.WriteLine("sum is:{0}", sum);
        Console.WriteLine("average is:{0}" , sum / n);
    }
}

