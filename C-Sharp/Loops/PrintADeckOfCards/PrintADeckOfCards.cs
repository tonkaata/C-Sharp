using System;

class PrintADeckOfCards
{
    static void Main()
    {
        string[] cardNumber = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        char[] cardNotation = { '\u2663', '\u2666', '\u2665', '\u2660' };

        foreach(var number in cardNumber)
        {
            foreach (var color in cardNotation)
            {
                Console.Write("{0}{1}, ",number, color);
            }
            Console.WriteLine();
        }
    }
}

