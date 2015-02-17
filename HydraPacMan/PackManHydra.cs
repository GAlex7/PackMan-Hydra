// най-напред да се преборим с GitHub!!!
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;

class PackManHydra
{
    static void Main(string[] args)
    {
        int[,] walls = CreateWallArr();
        // where the cells is 1 means that you can't go there

        DrawGameBoard();

        // Задаваме encoding за гадовете
        Console.OutputEncoding = Encoding.UTF8;

        // Задаваме размер на конзолата
        Console.BufferHeight = Console.WindowHeight; // 35
        Console.BufferWidth = Console.WindowWidth; //30

        // Изчистваме конзолата
        Console.Clear();
           
        // Принтиране на логото, изчакване за натискане на клавиш преди преминаване напред
        DrawLogo(20);
        // Меню: 1.New Game, 2.Load Game, 3.Score, 4.Exit
           
        // Ако е натиснато 1 -> чертаем лабиринта и на мястото на  READY да има брояч -> 3, 2, 1 (сменят се) -> GO
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

    private static void DrawLogo(int n)
    {
        int centerR = n / 2;
        int centerC = n / 2;
        int radius = n / 2;
        for (int r = 0; r < n; r++)
        {
            for (int c = 0; c < n; c++)
            {
                if ((c == radius + 2 && r == 5) || (c == radius + 2 && r == 6))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("-");
                }
                else if ((c == radius + 1 && r == 5) || (c == radius + 3 && r == 6))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("/");
                }
                else if ((c == radius + 3 && r == 5) || (c == radius + 1 && r == 6))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("\\");
                }
                else if ((int)Math.Abs(radius - c) * (int)Math.Abs(radius - c) +
                         (int)Math.Abs(radius - r) * (int)Math.Abs(radius - r) -1 <=
                                       radius * radius)
                {
                    if (r >= radius + 1 && (c - radius >= r - radius) ||
                        (c > radius && r == radius + 1))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write(" ");
                    }
                    else
                    {
                        if (c % 2 != r % 2)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        
                        Console.Write("*");
                    }

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        };
        Console.WriteLine();
    }
            
}
