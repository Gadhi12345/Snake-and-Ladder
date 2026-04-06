using System;

class Game
{
    static void Main()
    {
        int player1 = 0;
        Random random = new Random();

        while (player1 < 100)
        {
            int dice = random.Next(1, 7);
            int option = random.Next(0, 3);

            switch (option)
            {
                case 0:
                    break;
                case 1:
                    player1 += dice;
                    break;
                case 2:
                    player1 -= dice;
                    break;
            }

            if (player1 < 0)
                player1 = 0;

            Console.WriteLine("Position: " + player1);
        }
    }
}