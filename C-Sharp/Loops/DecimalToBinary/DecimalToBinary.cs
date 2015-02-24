//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

using System;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        long decNumber = long.Parse(Console.ReadLine());
        string binary = "";

        if (decNumber == 0)
        {
            Console.WriteLine("binary result is: 0");
        }
        else
        {
            while (decNumber >= 1)
            {
                binary = (decNumber % 2) + binary;
                decNumber = decNumber / 2;
            }
            Console.WriteLine("binary result is: {1}",
                decNumber, binary);
        }
    }
}
