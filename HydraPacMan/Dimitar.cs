using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class Dimitar
{
    public static int[,] monsterICoordinatesLevelOne = new int[88, 2] 
        {
            {13, 13},
            {13, 14},
            {13, 15},    
            {12, 15},
            {11, 15},
            {10, 15},
            {10, 16},
            {10, 17},
            {10, 18},
            {9, 18},
            {8, 18},
            {7, 18},
            {6, 18},
            {5, 18},
            {4, 18},
            {3, 18},
            {2, 18},
            {2, 19},
            {2, 20},
            {2, 21},
            {3, 21},
            {4, 21},
            {4, 22},
            {4, 23},
            {4, 24},
            {5, 24},
            {6, 24},
            {7, 24},
            {7, 23},
            {7, 22},
            {7, 21},
            {7, 20},
            {7, 19},
            {7, 18},
            {8, 18},
            {9, 18},
            {10, 18},
            {11, 18},
            {12, 18},
            {13, 18},
            {13, 19},
            {13, 20},
            {13, 21},
            {12, 21},
            {11, 21},
            {10, 21},
            {10, 22},
            {10, 23},
            {10, 24},
            {11, 24},
            {12, 24},
            {13, 24},
            {13, 25},
            {13, 26},
            {13, 27},
            {12, 27},
            {11, 27},
            {10, 27},
            {9, 27},
            {8, 27},
            {7, 27},
            {6, 27},
            {5, 27},
            {4, 27},
            {3, 27},
            {2, 27},
            {2,26},
            {2,25},
            {2,24},
            {3,24},
            {4,24},
            {5,24},
            {6,24},
            {7,24},
            {7,23},
            {7,22},
            {7,21},
            {8,21},
            {9,21},
            {10,21},
            {11,21},
            {12,21},
            {13,21},
            {13,20},
            {13,19},
            {13,18},
            {12,18},
            {11,18},
        };
    public static void MonsterIMovingLevelOne()
    {
        PackManHydra.badGuysCoordinates[3, 0] = PackManHydra.badGuysCoordinates[3, 2];
        PackManHydra.badGuysCoordinates[3, 1] = PackManHydra.badGuysCoordinates[3, 3];
        PackManHydra.badGuysCoordinates[3, 2] = monsterICoordinatesLevelOne[PackManHydra.GadThreeCounter, 0];
        PackManHydra.badGuysCoordinates[3, 3] = monsterICoordinatesLevelOne[PackManHydra.GadThreeCounter, 1];
        if (PackManHydra.GadThreeCounter == 87)
        {
            PackManHydra.GadThreeCounter = 8;
        }
        else
        {
            PackManHydra.GadThreeCounter++;
        }
        PackManHydra.badGuysCoordinates[3, 2] = monsterICoordinatesLevelOne[PackManHydra.GadThreeCounter, 0];
        PackManHydra.badGuysCoordinates[3, 3] = monsterICoordinatesLevelOne[PackManHydra.GadThreeCounter, 1];

    }

    public static void SetConsoleWidthAndHeight()
    {
        Console.WindowHeight = PackManHydra.windowHeight;
        Console.WindowWidth = PackManHydra.windowWidth;
        Console.BufferHeight = Console.WindowHeight;
        Console.BufferWidth = Console.WindowWidth;
    }
    
    public static void StartCounter()
    {
        Thread.Sleep(1000);
        Console.ForegroundColor = ConsoleColor.Green;
        for (int i = 3; i >= 0; i--)
        {
            Console.SetCursorPosition(13, 15);
            Console.Beep(1300, 100);
            Console.Write("- {0} - ", i);
            Thread.Sleep(900);

        }
        Console.SetCursorPosition(13, 15);
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("-GO!-");
        Console.Beep(1500, 1000);
        Console.SetCursorPosition(13, 15);
        Console.Write("     ");
        Console.SetCursorPosition(0, 30);
    }

    public static void LevelTwoMessage()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(8, 11);
        Console.Write("Congratulations!");
        Console.SetCursorPosition(1, 13);
        Console.Write("You passed C# 1 successfully");
        Console.SetCursorPosition(4, 14);
        Console.Write("but now the lectors are");
        Console.SetCursorPosition(7, 15);
        Console.Write("angrier than ever!");
        Console.SetCursorPosition(4, 17);
        Console.Write("They will do everything");
        Console.SetCursorPosition(10, 18);
        Console.Write("to stop you!");
        Console.SetCursorPosition(11, 20);
        Console.Write("Watch out...");


    }


}

