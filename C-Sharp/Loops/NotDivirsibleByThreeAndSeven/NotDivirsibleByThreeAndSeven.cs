using System;

class NotDivirsibleByThreeAndSeven
{
    static void Main()
    {
        Console.WriteLine("Enter positive integer:");
        int num = int.Parse(Console.ReadLine());
        int dividerA = 3;
        int dividerB = 7;

        for(int i = 1; i <= num; i++)
        {
            if(i % dividerA != 0 && i % dividerB != 0)
            {
                Console.Write(i + " ");
            }
        }
    }
}

