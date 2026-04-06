using System;

class Game
{
    static void Main()
    {
        int player1 = 0;
        Random random = new Random();

        int dice = random.Next(1, 7);
        int option = random.Next(0, 3);

        switch (option)
        {
            case 0:
                Console.WriteLine("No Play");
                break;

            case 1:
                Console.WriteLine("Ladder");
                player1 += dice;
                break;

            case 2:
                Console.WriteLine("Snake");
                player1 -= dice;
                break;
        }

        Console.WriteLine("Position: " + player1);
    }
}