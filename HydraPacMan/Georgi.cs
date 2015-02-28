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
        int x = 0;
        int y = 0;
        PackMan(crawliesPos);
        switch (PackManHydra.direction)
        {

            case 1:
                {
                    x = 1;
                    break;
                }
            case 2:
                {
                    x = -1;
                    break;
                }
            case 3:
                {
                    y = 1;
                    break;
                }
            case 4:
                {
                    y = -1;
                    break;
                }
        }

        char dotsChar;
        for (int i = 0; i < 5; i++)
        {
            // дали не е изяден
            if ((i != 0) &&
                (crawliesPos[0, 0] == crawliesPos[i, 0] || crawliesPos[0, 0] + x == crawliesPos[i, 0] || crawliesPos[0, 0] - x == crawliesPos[i, 0])
                &&
                (crawliesPos[0, 1] == crawliesPos[i, 1] || crawliesPos[0, 1] + y == crawliesPos[i, 1] || crawliesPos[0, 1] - y == crawliesPos[i, 1]))
            {
                Console.SetCursorPosition(crawliesPos[i, 0], crawliesPos[i, 1]);
                Console.Write(" ");

                Console.SetCursorPosition(13, 15);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("EATEN!");
                Thread.Sleep(1500); Console.SetCursorPosition(13, 15);
                Console.WriteLine("      ");
                crawliesPos[0, 0] = 15; crawliesPos[0, 1] = 21;
                crawliesPos[0, 2] = 15; crawliesPos[0, 3] = 21;
                PackManHydra.direction = 0;

                if (PackManHydra.lives < 1)
                {
                    Console.SetCursorPosition(0, 15);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("---------GAME OVER!!!---------");
                    PackManHydra.endGame = false;

                }
                else
                {
                    PackManHydra.lives--;
                }
            }
            else if (Mariyan.wallsLevelOne[crawliesPos[i, 3], crawliesPos[i, 2]] == 0)
            {

                if (i == 0)
                {
                    Console.SetCursorPosition(crawliesPos[i, 0], crawliesPos[i, 1]);
                    PackManHydra.points += PackManHydra.smallAndBigDots[crawliesPos[i, 1], crawliesPos[i, 0]] * 10;
                    Console.Write(" "); PackManHydra.smallAndBigDots[crawliesPos[i, 1], crawliesPos[i, 0]] = 0;

                    Console.SetCursorPosition(crawliesPos[i, 2], crawliesPos[i, 3]);
                    Console.ForegroundColor = (ConsoleColor)Enum.Parse(type, PackManHydra.colors[i]);
                    Console.Write(PackManHydra.ourGuy[PackManHydra.direction + 5]);
                    Thread.Sleep(50); Console.SetCursorPosition(crawliesPos[i, 2], crawliesPos[i, 3]);
                    Console.ForegroundColor = (ConsoleColor)Enum.Parse(type, PackManHydra.colors[i]);
                    Console.Write(PackManHydra.ourGuy[PackManHydra.direction]);

                    crawliesPos[i, 0] = crawliesPos[i, 2];
                    crawliesPos[i, 1] = crawliesPos[i, 3];

                }
                else
                {
                    Console.SetCursorPosition(crawliesPos[i, 0], crawliesPos[i, 1]);
                    switch (PackManHydra.smallAndBigDots[crawliesPos[i, 1], crawliesPos[i, 0]])
                    {
                        case 1:
                            {
                                dotsChar = '.';
                                break;
                            }
                        case 5:
                            {
                                dotsChar = '#';
                                break;
                            }
                        default:
                            {
                                dotsChar = ' ';
                                break;
                            }
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(dotsChar);
                    Console.SetCursorPosition(crawliesPos[i, 2], crawliesPos[i, 3]);
                    Console.ForegroundColor = (ConsoleColor)Enum.Parse(type, PackManHydra.colors[i]);
                    Console.Write(PackManHydra.badGuys[i]);
                    Console.ForegroundColor = ConsoleColor.Red;
                }


                // lifes level score
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(1, 30); Console.Write("   ");
                Console.SetCursorPosition(1, 30);
                Console.Write(new String(PackManHydra.badGuys[0], PackManHydra.lives));
                Console.SetCursorPosition(7, 30);
                Console.Write("Level:  {0}  Score:{1,6}", 1, PackManHydra.points);
                Console.ForegroundColor = ConsoleColor.Red;

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
                if (Mariyan.wallsLevelOne[y, x - 1] != 1)
                    posoka = left;
                //else posoka = stop;
            }
            if (userInput.Key == ConsoleKey.RightArrow)
            {
                if (Mariyan.wallsLevelOne[y, x + 1] != 1)
                    posoka = right;
                //else posoka = stop;
            }
            if (userInput.Key == ConsoleKey.UpArrow)
            {
                if (Mariyan.wallsLevelOne[y - 1, x] != 1)
                    posoka = up;
                //else posoka = stop;
            }
            if (userInput.Key == ConsoleKey.DownArrow)
            {
                if (Mariyan.wallsLevelOne[y + 1, x] != 1)
                    posoka = down;
                //else posoka = stop;
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

