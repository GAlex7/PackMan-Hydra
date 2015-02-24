using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

class Georgi
{

    // Изчертаване на екрана
    static public void RefreshScreen(int[,] crawliesPos)
    {
        Type type = typeof(ConsoleColor);

        PackMan(crawliesPos);

        for (int i = 0; i < 5; i++)
        {

            if (PackManHydra.walls[crawliesPos[i, 3], crawliesPos[i, 2]] == 0)
            {
                Console.SetCursorPosition(crawliesPos[i, 0], crawliesPos[i, 1]);
                Console.Write(" ");
                Console.SetCursorPosition(crawliesPos[i, 2], crawliesPos[i, 3]);
                Console.ForegroundColor = (ConsoleColor)Enum.Parse(type, PackManHydra.colors[i]);
                if (i == 0)
                {
                    Console.Write(PackManHydra.ourGuy[PackManHydra.direction + 5]);
                    Thread.Sleep(50); Console.SetCursorPosition(crawliesPos[i, 2], crawliesPos[i, 3]);
                    Console.Write(PackManHydra.ourGuy[PackManHydra.direction]);
                }
                else Console.Write(PackManHydra.badGuys[i]);
                PackManHydra.points += PackManHydra.smallAndBigDots[crawliesPos[i, 3], crawliesPos[i, 2]];
                crawliesPos[i, 0] = crawliesPos[i, 2];
                crawliesPos[i, 1] = crawliesPos[i, 3];
                // lifes level score
                Console.SetCursorPosition(1, 30);
                Console.Write(new String(PackManHydra.badGuys[0], PackManHydra.lives));
                Console.SetCursorPosition(7, 30);
                Console.WriteLine("Level: {0}  Score: {1,6}", 1, PackManHydra.points);

            }
        }
    }
    static public void PackMan(int[,] coordinates)
    {
        byte stop = 0;
        byte right = 1;
        byte left = 2;
        byte down = 3;
        byte up = 4;
        int x = coordinates[0, 0];
        int y = coordinates[0, 1];
        int[][] directions = new int[5][];
        directions[0] = new int[] { 0, 0 };  // just staing
        directions[1] = new int[] { 0, 1 };  // right
        directions[2] = new int[] { 0, -1 }; // left
        directions[3] = new int[] { 1, 0 };  // down
        directions[4] = new int[] { -1, 0 }; // up

        int posoka = PackManHydra.direction;
        if (Console.KeyAvailable)
        {
            ConsoleKeyInfo userInput = Console.ReadKey();
            if (userInput.Key == ConsoleKey.LeftArrow)
            {
                if (PackManHydra.walls[y, x - 1] != 1)
                    posoka = left;
                else posoka = stop;
            }
            if (userInput.Key == ConsoleKey.RightArrow)
            {
                if (PackManHydra.walls[y, x + 1] != 1)
                    posoka = right;
                else posoka = stop;
            }
            if (userInput.Key == ConsoleKey.UpArrow)
            {
                if (PackManHydra.walls[y - 1, x] != 1)
                    posoka = up;
                else posoka = stop;
            }
            if (userInput.Key == ConsoleKey.DownArrow)
            {
                if (PackManHydra.walls[y + 1, x] != 1)
                    posoka = down;
                else posoka = stop;
            }
        }
        // moving...
        if (posoka == left && x == 0)
            coordinates[0, 2] = 29;
        else if (posoka == right && x == 29)
            coordinates[0, 2] = 0;
        else coordinates[0, 2] = x + directions[posoka][1];
        coordinates[0, 3] = y + directions[posoka][0];
        PackManHydra.direction = posoka;
    }
}

