﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class PackManHydra
    {
        static void Main(string[] args)
        {
            // Задаваме размер на конзолата

            Console.BufferHeight = Console.WindowHeight; // 35
            Console.BufferWidth = Console.WindowWidth; //30

            Console.Clear();

            // Принтиране на логото, изчакване за натискане на клавиш преди преминаване напред

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

        /*int[,] walls = CreateWallArr();
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
            Console.WriteLine("Our game board contains {0} rows and {1} cols.", walls.GetLength(0), walls.GetLength(1));*/
    }
