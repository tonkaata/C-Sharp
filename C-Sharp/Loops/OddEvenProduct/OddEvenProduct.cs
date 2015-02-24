//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is 
//equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, 
//the second is even, etc.

using System;

class OddEvenProduct
{
    static void Main()
    {
        Console.WriteLine("Enter numbers, separated by space");
        string lineNumbers = Console.ReadLine();
        string[] numbers = lineNumbers.Split(' ');
        int length = numbers.Length;
        int odd = 1;
        int even = 1;

        for (int i = 0; i < length; i++)
        {
            int number;
            bool isNumber = int.TryParse(numbers[i], out number);
            if (isNumber)
            {
                if (i % 2 != 0)
                {
                    odd *= number;
                }
                else if (i % 2 == 0)
                {
                    even *= number;
                }
            }
        }
        if (even == odd)
        {
            Console.WriteLine("The product is = {0}", even);
        }
        else
        {
            Console.WriteLine("The even product is = {0}\nThe odd product is = {1}",
                even, odd);
        }
    }
}

