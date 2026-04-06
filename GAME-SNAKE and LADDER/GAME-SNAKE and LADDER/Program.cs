using System;

class Game
{
    static void Main()
    {
        int player1 = 0;
        int player2 = 0;
        int currentPlayer = 1;

        Random random = new Random();

        while (player1 < 100 && player2 < 100)
        {
            int dice = random.Next(1, 7);
            int option = random.Next(0, 3);

            Console.WriteLine("\nPlayer " + currentPlayer + " rolled: " + dice);

            int temp = (currentPlayer == 1) ? player1 : player2;

            switch (option)
            {
                case 0:
                    Console.WriteLine("No Play");
                    break;

                case 1:
                    Console.WriteLine("Ladder");
                    temp += dice;
                    break;

                case 2:
                    Console.WriteLine("Snake");
                    temp -= dice;
                    break;
            }

            if (temp >= 0 && temp <= 100)
            {
                if (currentPlayer == 1)
                    player1 = temp;
                else
                    player2 = temp;
            }

            Console.WriteLine("P1: " + player1 + " | P2: " + player2);

            if (option != 1)
                currentPlayer = (currentPlayer == 1) ? 2 : 1;
        }

        Console.WriteLine((player1 == 100) ? "Player 1 Wins!" : "Player 2 Wins!");
    }
}