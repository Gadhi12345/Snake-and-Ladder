using System;

class Game
{
    static void Main()
    {
        int player1 = 0;
        int count = 0;
        Random random = new Random();

        while (player1 < 100)
        {
            int dice = random.Next(1, 7);
            int option = random.Next(0, 3);

            count++;

            int temp = player1;

            switch (option)
            {
                case 0:
                    break;
                case 1:
                    temp += dice;
                    break;
                case 2:
                    temp -= dice;
                    break;
            }

            if (temp >= 0 && temp <= 100)
                player1 = temp;

            Console.WriteLine("Roll: " + count + " Position: " + player1);
        }

        Console.WriteLine("Total Rolls: " + count);
    }
}