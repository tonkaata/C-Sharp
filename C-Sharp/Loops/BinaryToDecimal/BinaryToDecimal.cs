﻿//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Binary: ");
        string binary = Console.ReadLine();
        long decimalNumber = 0;

        for (int i = 0; i < binary.Length; i++)
        {
            if (binary[binary.Length - i - 1] == '0')
            {
                continue;
            }
            decimalNumber += (long)Math.Pow(2, i);
        }
        Console.WriteLine("decimal of {0} is: {1}", binary, decimalNumber);
    }
}

