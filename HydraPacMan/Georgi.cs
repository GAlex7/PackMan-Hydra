using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Georgi
{
    // Изчертаване на екрана
    static public void RefreshScreen(int[,] crawliesPos)
    {
        Type type = typeof(ConsoleColor);

        for (int i = 0; i < 5; i++)
        {
            if (PackManHydra.walls[crawliesPos[i, 2], crawliesPos[i, 3]] == 0)
            {
                Console.SetCursorPosition(crawliesPos[i, 0], crawliesPos[i, 1]);
                Console.Write(" ");
                Console.SetCursorPosition(crawliesPos[i, 2], crawliesPos[i, 3]);
                Console.BackgroundColor = (ConsoleColor)Enum.Parse(type, PackManHydra.colors[i]);
                Console.Write(PackManHydra.badGuys[i]);
            }
        }
    }
}

