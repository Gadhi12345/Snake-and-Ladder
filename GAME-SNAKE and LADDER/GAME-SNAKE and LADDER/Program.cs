using System;

class UC2
{
    static void Main()
    {
        Random random = new Random();
        int dice = random.Next(1, 7);

        Console.WriteLine("Dice rolled: " + dice);
    }
}