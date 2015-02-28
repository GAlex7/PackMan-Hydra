using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Ivaylo
{
    // Гад 1 -> M row 13 col 17 GadOneCounter = 0; -> +1
    public static void MonsterNMoving()
    {
        PackManHydra.badGuysCoordinates[1, 0] = PackManHydra.badGuysCoordinates[1, 2];
        PackManHydra.badGuysCoordinates[1, 1] = PackManHydra.badGuysCoordinates[1, 3];
        PackManHydra.badGuysCoordinates[1, 2] = PackManHydra.monsterArray[PackManHydra.GadOneCounter, 0];
        PackManHydra.badGuysCoordinates[1, 3] = PackManHydra.monsterArray[PackManHydra.GadOneCounter, 1];
        if (PackManHydra.GadOneCounter == 56)
        {
            PackManHydra.GadOneCounter = 6;
        }
        else
        {
            PackManHydra.GadOneCounter++;
        }
        PackManHydra.badGuysCoordinates[1, 2] = PackManHydra.monsterArray[PackManHydra.GadOneCounter, 0];
        PackManHydra.badGuysCoordinates[1, 3] = PackManHydra.monsterArray[PackManHydra.GadOneCounter, 1];
    }

    public static int[,] monsterNCoordinatesLevelTwo = new int[103, 2] 
        {
            {17, 13},    
            {17, 14},
            {17, 15},
            {18, 15},
            {19, 15},
            {20, 15},
            {20, 16},
            {20, 17},
            {20, 18},
            {19, 18},
            {18, 18},
            {17, 18},
            {17, 19},
            {17, 20},
            {17, 21},
            {18, 21},
            {19, 21},
            {20, 21},
            {20, 22},
            {20, 23},
            {20, 24},
            {19, 24},
            {18, 24},
            {17, 24},
            {17, 25},
            {17, 26},
            {17, 27},
            {18, 27},
            {19, 27},
            {20, 27},
            {21, 27},
            {22, 27},
            {23, 27},
            {24, 27},
            {25, 27},
            {26, 27},
            {27, 27},
            {28, 27},
            {28, 26},
            {28, 25},
            {28, 24},
            {27, 24},
            {26, 24},
            {25, 24},
            {24, 24},
            {23, 24},
            {24, 24},
            {25, 24},
            {26, 24},
            {26, 23},
            {26, 22},
            {26, 21},
            {27, 21},
            {28, 21},
            {28, 20},
            {28, 19},
            {28, 18},
            {27, 18},
            {26, 18},
            {27, 18},
            {28, 18},
            {28, 19},
            {28, 20},
            {28, 21},
            {27, 21},
            {26, 21},
            {26, 22},
            {26, 23},
            {26, 24},
            {27, 24},
            {28, 24},
            {28, 25},
            {28, 26},
            {28, 27},
            {27, 27},
            {26, 27},
            {25, 27},
            {24, 27},
            {23, 27},
            {22, 27},
            {21, 27},
            {20, 27},
            {19, 27},
            {18, 27},
            {17, 27},
            {17, 26},
            {17, 25},
            {17, 24},
            {18, 24},
            {19, 24},
            {20, 24},
            {20, 23},
            {20, 22},
            {20, 21},
            {21, 21},
            {22, 21},
            {23, 21},
            {23, 20},
            {23, 19},
            {23, 18},
            {22, 18},
            {21, 18},
            {20, 18},
        };

    public static void MonsterNMovingLevelTwo()
    {
        PackManHydra.badGuysCoordinates[1, 0] = PackManHydra.badGuysCoordinates[1, 2];
        PackManHydra.badGuysCoordinates[1, 1] = PackManHydra.badGuysCoordinates[1, 3];
        PackManHydra.badGuysCoordinates[1, 2] = monsterNCoordinatesLevelTwo[PackManHydra.GadOneCounter, 0];
        PackManHydra.badGuysCoordinates[1, 3] = monsterNCoordinatesLevelTwo[PackManHydra.GadOneCounter, 1];
        if (PackManHydra.GadOneCounter == 102)
        {
            PackManHydra.GadOneCounter = 9;
        }
        else
        {
            PackManHydra.GadOneCounter++;
        }
        PackManHydra.badGuysCoordinates[1, 2] = monsterNCoordinatesLevelTwo[PackManHydra.GadOneCounter, 0];
        PackManHydra.badGuysCoordinates[1, 3] = monsterNCoordinatesLevelTwo[PackManHydra.GadOneCounter, 1];
    }

    public static int[,] monsterECoordinatesLevelTwo = new int[79, 2] 
        {
            {10, 3},    
            {10, 4},
            {10, 5},
            {10, 6},
            {10, 7},
            {10, 8},
            {11, 8},
            {12, 8},
            {13, 8},
            {13, 9},
            {13, 10},
            {13, 11},
            {12, 11},
            {11, 11},
            {10, 11},
            {10, 12},
            {10, 13},
            {9, 13},
            {8, 13},
            {7, 13},
            {7, 12},
            {7, 11},
            {7, 10},
            {7, 9},
            {7, 8},
            {7, 7},
            {7, 6},
            {7, 5},
            {6, 5},
            {5, 5},
            {4, 5},
            {3, 5},
            {2, 5},
            {2, 6},
            {2, 7},
            {2, 8},
            {3, 8},
            {4, 8},
            {5, 8},
            {6, 8},
            {7, 8},
            {7, 7},
            {7, 6},
            {7, 5},
            {8, 5},
            {9, 5},
            {10, 5},
            {11, 5},
            {12, 5},
            {13, 5},
            {13, 4},
            {13, 3},
            {13, 2},
            {13, 1},
            {12, 1},
            {11, 1},
            {10, 1},
            {9, 1},
            {8, 1},
            {7, 1},
            {6, 1},
            {5, 1},
            {4, 1},
            {3, 1},
            {2, 1},
            {2, 1},
            {2, 2},
            {2, 3},
            {2, 4},
            {2, 5},
            {3, 5},
            {4, 5},
            {5, 5},
            {6, 5},
            {7, 5},
            {8, 5},
            {9, 5},
            {10, 5},
            {10, 6},
        };

    public static void MonsterEMovingLevelTwo()
    {
        PackManHydra.badGuysCoordinates[2, 0] = PackManHydra.badGuysCoordinates[2, 2];
        PackManHydra.badGuysCoordinates[2, 1] = PackManHydra.badGuysCoordinates[2, 3];
        PackManHydra.badGuysCoordinates[2, 2] = monsterECoordinatesLevelTwo[PackManHydra.GadTwoCounter, 0];
        PackManHydra.badGuysCoordinates[2, 3] = monsterECoordinatesLevelTwo[PackManHydra.GadTwoCounter, 1];
        if (PackManHydra.GadTwoCounter == 78)
        {
            PackManHydra.GadTwoCounter = 4;
        }
        else
        {
            PackManHydra.GadTwoCounter++;
        }
        PackManHydra.badGuysCoordinates[2, 2] = monsterECoordinatesLevelTwo[PackManHydra.GadTwoCounter, 0];
        PackManHydra.badGuysCoordinates[2, 3] = monsterECoordinatesLevelTwo[PackManHydra.GadTwoCounter, 1];
    }

    public static void PrintingMenuGame()
    {
        Console.SetCursorPosition(5, 11);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("********************\n");
        Console.SetCursorPosition(5, 12);
        Console.Write("*       ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("MENU");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("       *\n");
        Console.SetCursorPosition(5, 13);
        Console.Write("*                  *\n");
        Console.SetCursorPosition(5, 14);
        Console.Write("*  ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("1. NEW GAME   ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("  *\n");
        Console.SetCursorPosition(5, 15);
        Console.Write("*                  *\n");
        Console.SetCursorPosition(5, 16);
        Console.Write("*  ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("2. INSTRUCTION");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("  *\n");
        Console.SetCursorPosition(5, 17);
        Console.Write("*                  *\n");
        Console.SetCursorPosition(5, 18);
        Console.Write("*  ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("3. HIGH SCORES");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("  *\n");
        Console.SetCursorPosition(5, 19);
        Console.Write("*                  *\n");
        Console.SetCursorPosition(5, 20);
        Console.Write("*  ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("4. EXIT GAME  ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("  *\n");
        Console.SetCursorPosition(5, 21);
        Console.Write("*                  *\n");
        Console.SetCursorPosition(5, 22);
        Console.Write("********************");
        Console.WriteLine();
        Console.CursorVisible = false;

    }
}