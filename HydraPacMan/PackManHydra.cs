
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class PackManHydra
{
    static void Main(string[] args)
    {
        int[,] walls = CreateWallArr();
        // where the cells is 1 means that you can't go there

        DrawGameBoard();

        Console.WriteLine();
        for (int r = 0; r < walls.GetLength(0); r++)
        {
            for (int c = 0; c < walls.GetLength(1); c++)
            {
                Console.Write(walls[r, c] == 1 ? 'M' : '.');
            }
            Console.WriteLine();
        }
        Console.WriteLine("Our game board contains {0} rows and {1} cols.", walls.GetLength(0), walls.GetLength(1));
        ConsoleKeyInfo kk = Console.ReadKey(false);
        if (kk.Key == ConsoleKey.LeftArrow)
        {
            Console.WriteLine("You pressed Left Arrow");
        }
        if (kk.Key == ConsoleKey.RightArrow)
        {
            Console.WriteLine("You pressed Right Arrow");
        }
        if (kk.Key == ConsoleKey.UpArrow)
        {
            Console.WriteLine("You pressed Up Arrow");
        }
        if (kk.Key == ConsoleKey.DownArrow)
        {
            Console.WriteLine("You pressed Down Arrow");
        }
    }

    private static void DrawGameBoard()
    {
        Console.WriteLine("┌────────────┐ ┌────────────┐");
        Console.WriteLine("│............│ │............│");
        Console.WriteLine("│.┌──┐.┌───┐.│ │.┌───┐.┌──┐.│");
        Console.WriteLine("│.│  │.│ # │.│ │.│ # │.│  │.│");
        Console.WriteLine("│@└──┘.└─┘└┘.└─┘.└┘└─┘.└──┘@│");
        Console.WriteLine("│...........................│");
        Console.WriteLine("│.┌──┐.┌┐.┌───────┐.┌┐.┌──┐.│");
        Console.WriteLine("│.└──┘.││.└──┐ ┌──┘.││.└──┘.│");
        Console.WriteLine("│......││....│ │....││......│");
        Console.WriteLine("└────┐.│└──┐ │ │ ┌──┘│.┌────┘");
        Console.WriteLine("     │.│┌──┘ └─┘ └──┐│.│     ");
        Console.WriteLine("     │.││           ││.│     ");
        Console.WriteLine("─────┘.└┘ ┌─┐┌─┐┌─┐ └┘.└─────");
        Console.WriteLine("      .   │ #   # │   .      ");
        Console.WriteLine("─────┐.┌┐ └───────┘ ┌┐.┌─────");
        Console.WriteLine("     │.││   READY!  ││.│     ");
        Console.WriteLine("     │.││ ┌───────┐ ││.│     ");
        Console.WriteLine("┌────┘.└┘ └──┐ ┌──┘ └┘.└────┐");
        Console.WriteLine("│............│ │............│");
        Console.WriteLine("│.┌──┐.┌───┐.│ │.┌───┐.┌──┐.│");
        Console.WriteLine("│.└─┐│.└───┘.└─┘.└───┘.│┌─┘.│");
        Console.WriteLine("│@..││....... X .......││..@│");
        Console.WriteLine("└─┐.││.┌┐.┌───────┐.┌┐.││.┌─┘");
        Console.WriteLine("┌─┘.└┘.││.└──┐ ┌──┘.││.└┘.└─┐");
        Console.WriteLine("│......││....│ │....││......│");
        Console.WriteLine("│.┌────┘└──┐.│ │.┌──┘└────┐.│");
        Console.WriteLine("│.└────────┘.└─┘.└────────┘.│");
        Console.WriteLine("│...........................│");
        Console.WriteLine("└───────────────────────────┘");
    }

    private static int[,] CreateWallArr()
    {
        int[,] wallsArr = new int[,]
            {
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
            {1,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,0,1,1,1,1,0,1,1,1,1,1,0,1,1,1,0,1,1,1,1,1,0,1,1,1,1,0,1},
            {1,0,1,1,1,1,0,1,1,1,1,1,0,1,1,1,0,1,1,1,1,1,0,1,1,1,1,0,1},
            {1,0,1,1,1,1,0,1,1,1,1,1,0,1,1,1,0,1,1,1,1,1,0,1,1,1,1,0,1},
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,0,1,1,1,1,0,1,1,0,1,1,1,1,1,1,1,1,1,0,1,1,0,1,1,1,1,0,1},
            {1,0,1,1,1,1,0,1,1,0,1,1,1,1,1,1,1,1,1,0,1,1,0,1,1,1,1,0,1},
            {1,0,0,0,0,0,0,1,1,0,0,0,0,1,1,1,0,0,0,0,1,1,0,0,0,0,0,0,1},
            {1,1,1,1,1,1,0,1,1,1,1,1,0,1,1,1,0,1,1,1,1,1,0,1,1,1,1,1,1},
            {1,1,1,1,1,1,0,1,1,1,1,1,0,1,1,1,0,1,1,1,1,1,0,1,1,1,1,1,1},
            {1,1,1,1,1,1,0,1,1,0,0,0,0,0,0,0,0,0,0,0,1,1,0,1,1,1,1,1,1},
            {1,1,1,1,1,1,0,1,1,0,1,1,1,1,1,1,1,1,1,0,1,1,0,1,1,1,1,1,1},
            {0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0},
            {1,1,1,1,1,1,0,1,1,0,1,1,1,1,1,1,1,1,1,0,1,1,0,1,1,1,1,1,1},
            {1,1,1,1,1,1,0,1,1,0,0,0,0,0,0,0,0,0,0,0,1,1,0,1,1,1,1,1,1},
            {1,1,1,1,1,1,0,1,1,0,1,1,1,1,1,1,1,1,1,0,1,1,0,1,1,1,1,1,1},
            {1,1,1,1,1,1,0,1,1,0,1,1,1,1,1,1,1,1,1,0,1,1,0,1,1,1,1,1,1},
            {1,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,0,1,1,1,1,0,1,1,1,1,1,0,1,1,1,0,1,1,1,1,1,0,1,1,1,1,0,1},
            {1,0,1,1,1,1,0,1,1,1,1,1,0,1,1,1,0,1,1,1,1,1,0,1,1,1,1,0,1},
            {1,0,0,0,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,0,0,0,1},
            {1,1,1,0,1,1,0,1,1,0,1,1,1,1,1,1,1,1,1,0,1,1,0,1,1,0,1,1,1},
            {1,1,1,0,1,1,0,1,1,0,1,1,1,1,1,1,1,1,1,0,1,1,0,1,1,0,1,1,1},
            {1,0,0,0,0,0,0,1,1,0,0,0,0,1,1,1,0,0,0,0,1,1,0,0,0,0,0,0,1},
            {1,0,1,1,1,1,1,1,1,1,1,1,0,1,1,1,0,1,1,1,1,1,1,1,1,1,1,0,1},
            {1,0,1,1,1,1,1,1,1,1,1,1,0,1,1,1,0,1,1,1,1,1,1,1,1,1,1,0,1},
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}
            };
        return wallsArr;
    }

    //if (Console.KeyAvailable)
    //            {
    //                ConsoleKeyInfo userInput = Console.ReadKey();
    //                if (userInput.Key == ConsoleKey.LeftArrow)
    //                {
    //                    if (direction != right) direction = left;
    //                }
    //                if (userInput.Key == ConsoleKey.RightArrow)
    //                {
    //                    if (direction != left) direction = right;
    //                }
    //                if (userInput.Key == ConsoleKey.UpArrow)
    //                {
    //                    if (direction != down) direction = up;
    //                }
    //                if (userInput.Key == ConsoleKey.DownArrow)
    //                {
    //                    if (direction != up) direction = down;
    //                }
    //            }
}