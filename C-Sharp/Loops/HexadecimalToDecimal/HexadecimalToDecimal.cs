//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Enter hexadecimal number: ");
        string hexaNumber = Console.ReadLine();
        long decNumber = 0;
        int lastIndex = hexaNumber.Length - 1;

        for (int i = 0; i < hexaNumber.Length; i++, lastIndex--)
        {
            int num;
            switch (hexaNumber[i])
            {
                case 'A': num = 10;
                    break;
                case 'B': num = 11;
                    break;
                case 'C': num = 12;
                    break;
                case 'D': num = 13;
                    break;
                case 'E': num = 14;
                    break;
                case 'F': num = 15;
                    break;
                default: num = int.Parse(hexaNumber[i].ToString());
                    break;
            }
            long hexSum = 1;
            for (int j = 0; j < lastIndex; j++)
            {
                hexSum *= 16;
            }
            hexSum *= num;
            decNumber += hexSum;
        }
        Console.WriteLine("The decimal value is: {0}",
            decNumber);
    }
}

