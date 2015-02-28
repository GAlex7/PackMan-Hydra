﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Marian
{
    // Гад 4 - > W

    public static void MonsterDLevelOne()
    {
        PackManHydra.badGuysCoordinates[4, 0] = PackManHydra.badGuysCoordinates[4, 2];
        PackManHydra.badGuysCoordinates[4, 1] = PackManHydra.badGuysCoordinates[4, 3];
        PackManHydra.badGuysCoordinates[4, 2] = PackManHydra.monsterW[PackManHydra.GadFourCounter, 0];
        PackManHydra.badGuysCoordinates[4, 3] = PackManHydra.monsterW[PackManHydra.GadFourCounter, 1];
        if (PackManHydra.GadFourCounter == 102)
        {
            PackManHydra.GadFourCounter = 0;
        }
        else
        {
            PackManHydra.GadFourCounter++;
        }
        PackManHydra.badGuysCoordinates[4, 2] = PackManHydra.monsterW[PackManHydra.GadFourCounter, 0];
        PackManHydra.badGuysCoordinates[4, 3] = PackManHydra.monsterW[PackManHydra.GadFourCounter, 1];
    }

    public static void MonsterILevelTwo()
    {
        PackManHydra.badGuysCoordinates[3, 0] = PackManHydra.badGuysCoordinates[3, 2];
        PackManHydra.badGuysCoordinates[3, 1] = PackManHydra.badGuysCoordinates[3, 3];
        PackManHydra.badGuysCoordinates[3, 2] = PackManHydra.monsterW[PackManHydra.GadFourCounter, 0];
        PackManHydra.badGuysCoordinates[3, 3] = PackManHydra.monsterW[PackManHydra.GadFourCounter, 1];
        if (PackManHydra.GadFourCounter == 117)
        {
            PackManHydra.GadFourCounter = 5;
        }
        else
        {
            PackManHydra.GadFourCounter++;
        }
        PackManHydra.badGuysCoordinates[3, 2] = PackManHydra.monsterW[PackManHydra.GadFourCounter, 0];
        PackManHydra.badGuysCoordinates[3, 3] = PackManHydra.monsterW[PackManHydra.GadFourCounter, 1];
    }

    public static int[,] monsterICoordinatesLevelTwo = new int[118, 2] 
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
            {7, 17},
            {7, 16},
            {7, 15},
            {7, 14},
            {7, 13},
            {6, 13},
            {5, 13},
            {4, 13},
            {3, 13},
            {2, 13},
            {1, 13},
            {0, 13},
            {15, 27},
            {14, 27},
            {13, 27},
            {12, 27},
            {11, 27},
            {10, 27},
            {09, 27},
            {08, 27},
            {07, 27},
            {06, 27},
            {05, 27},
            {04, 27},
            {03, 27},
            {02, 27},
            {2, 26},
            {2, 25},
            {2, 24},
            {3, 24},
            {4, 24},
            {5, 24},
            {6, 24},
            {7, 24},
            {7, 23},
            {7, 24},
            {6, 24},
            {5, 24},
            {4, 24},
            {4, 23},
            {4, 22},
            {4, 21},
            {3, 21},
            {2, 21},
            {2, 20},
            {2, 19},
            {2, 18},
            {3, 18},
            {4, 18},
            {3, 18},
            {2, 18},
            {2, 18},
            {2, 19},
            {2, 20},
            {2, 21},
            {3, 21},
            {4, 21},
            {4, 22},
            {4, 23},
            {4, 24},
            {3, 24},
            {2, 24},
            {2, 25},
            {2, 26},
            {2, 27},
            {3, 27},
            {4, 27},
            {5, 27},
            {6, 27},
            {7, 27},
            {8, 27},
            {9, 27},
            {10, 27},
            {11, 27},
            {12, 27},
            {13, 27},
            {13, 26},
            {13, 25},
            {13, 24},
            {12, 24},
            {11, 24},
            {10, 24},
            {10, 23},
            {10, 22},
            {10, 21},
            {11, 21},
            {12, 21},
            {13, 21},
            {13, 20},
            {13, 19},
            {13, 18},
            {12, 18},
            {11, 18},
            {10, 18},
            {09, 18},
            {08, 18},
            {07, 18},
            {07, 17},
            {07, 16},
            {07, 15},
            {07, 14},
            {07, 13},
            {08, 13},
            {09, 13},
            {10, 13},
            {10, 14}
        };

    public static void DrawGameBoardLevelOne()
    {
        Console.WriteLine(" ┌────────────┐ ┌────────────┐");
        Console.WriteLine(" │............│ │............│");
        Console.WriteLine(" │.┌──┐.┌───┐.│ │.┌───┐.┌──┐.│");
        Console.WriteLine(" │.│  │.│ Е │.│ │.│ Д │.│  │.│");
        Console.WriteLine(" │#└──┘.└┘─└┘.└─┘.└┘─└┘.└──┘#│");
        Console.WriteLine(" │...........................│");
        Console.WriteLine(" │.┌──┐.┌┐.┌───────┐.┌┐.┌──┐.│");
        Console.WriteLine(" │.└──┘.││.└──┐ ┌──┘.││.└──┘.│");
        Console.WriteLine(" │......││....│ │....││......│");
        Console.WriteLine(" └────┐.│└──┐ │ │ ┌──┘│.┌────┘");
        Console.WriteLine("      │.│┌──┘ └─┘ └──┐│.│     ");
        Console.WriteLine("      │.││           ││.│     ");
        Console.WriteLine("──────┘.└┘ ┌───────┐ └┘.└─────");
        Console.WriteLine("       .   │ И   Н │   .      ");//13
        Console.WriteLine("──────┐.┌┐ └┘─└─┘─└┘ ┌┐.┌─────");
        Console.WriteLine("      │.││   READY!  ││.│     ");
        Console.WriteLine("      │.││ ┌───────┐ ││.│     ");
        Console.WriteLine(" ┌────┘.└┘ └──┐ ┌──┘ └┘.└────┐");
        Console.WriteLine(" │............│ │............│");
        Console.WriteLine(" │.┌──┐.┌───┐.│ │.┌───┐.┌──┐.│");
        Console.WriteLine(" │.└─┐│.└───┘.└─┘.└───┘.│┌─┘.│");
        Console.WriteLine(" │#..││....... X .......││..#│");
        Console.WriteLine(" └─┐.││.┌┐.┌───────┐.┌┐.││.┌─┘");
        Console.WriteLine(" ┌─┘.└┘.││.└──┐ ┌──┘.││.└┘.└─┐");
        Console.WriteLine(" │......││....│ │....││......│");
        Console.WriteLine(" │.┌────┘└──┐.│ │.┌──┘└────┐.│");
        Console.WriteLine(" │.└────────┘.└─┘.└────────┘.│");
        Console.WriteLine(" │...........................│");
        Console.WriteLine(" └───────────────────────────┘");
    }

    public static void DrawGameBoardLevelTwo()
    {
        Console.WriteLine(" ┌───────────┐   ┌───────────┐");
        Console.WriteLine(" │...........................│");
        Console.WriteLine(" │.┌─────▄▄▄┐.┌─┐.┌▄▄▄─────┐.│");
        Console.WriteLine(" │.│#     Е │.│ │.│ Д     #│.│");
        Console.WriteLine(" │.└─────┘─└┘.└─┘.└┘─└─────┘.│");
        Console.WriteLine(" │...........................│");
        Console.WriteLine(" │.┌──┐.┌┐.┌───────┐.┌┐.┌──┐.│");
        Console.WriteLine(" │.└──┘.││.└──┐ ┌──┘.││.└──┘.│");
        Console.WriteLine(" │......││....│ │....││......│");
        Console.WriteLine(" └────┐.│└──┐ │ │ ┌──┘│.┌────┘");
        Console.WriteLine("      │.│┌──┘ └─┘ └──┐│.│     ");
        Console.WriteLine("      │.││           ││.│     ");
        Console.WriteLine("──────┘.└┘ ┌───────┐ └┘.└─────");
        Console.WriteLine("       .   │ И   Н │   .      ");
        Console.WriteLine("──────┐.┌┐ └┘─└─┘─└┘ ┌┐.┌─────");
        Console.WriteLine("      │.││   READY!  ││.│     ");
        Console.WriteLine("      │.││ ┌───────┐ ││.│     ");
        Console.WriteLine(" ┌───┐│.└┘ └──┐ ┌──┘ └┘.│┌───┐");
        Console.WriteLine(" │..#││.......│ │.......││#..│");
        Console.WriteLine(" │.┌─┘│.┌───┐.│ │.┌───┐.│└─┐.│");
        Console.WriteLine(" │.└─┐│.└───┘.└─┘.└───┘.│┌─┘.│");
        Console.WriteLine(" │...││....... X .......││...│");
        Console.WriteLine(" └─┐.│╞═╤╕.┌───────┐.╒╤═╡│.┌─┘");
        Console.WriteLine(" ┌─┘.└┘.││.└──┐ ┌──┘.││.└┘.└─┐");
        Console.WriteLine(" │......││....│ │....││......│");
        Console.WriteLine(" │.┌────┘└──┐.│ │.┌──┘└────┐.│");
        Console.WriteLine(" │.└────────┘.└─┘.└────────┘.│");
        Console.WriteLine(" │...........................│");
        Console.WriteLine(" └───────────┘   └───────────┘");
    }

    public static int[,] wallsLevelOne =
    {
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
            {1,1,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,1,0,1,1,1,1,0,1,1,1,1,1,0,1,1,1,0,1,1,1,1,1,0,1,1,1,1,0,1},
            {1,1,0,1,1,1,1,0,1,0,0,0,1,0,1,1,1,0,1,0,0,0,1,0,1,1,1,1,0,1},
            {1,1,0,1,1,1,1,0,1,1,0,1,1,0,1,1,1,0,1,1,0,1,1,0,1,1,1,1,0,1},
            {1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,1,0,1,1,1,1,0,1,1,0,1,1,1,1,1,1,1,1,1,0,1,1,0,1,1,1,1,0,1},
            {1,1,0,1,1,1,1,0,1,1,0,1,1,1,1,1,1,1,1,1,0,1,1,0,1,1,1,1,0,1},
            {1,1,0,0,0,0,0,0,1,1,0,0,0,0,1,1,1,0,0,0,0,1,1,0,0,0,0,0,0,1},
            {1,1,1,1,1,1,1,0,1,1,1,1,1,0,1,1,1,0,1,1,1,1,1,0,1,1,1,1,1,1},
            {1,1,1,1,1,1,1,0,1,1,1,1,1,0,1,1,1,0,1,1,1,1,1,0,1,1,1,1,1,1},
            {1,1,1,1,1,1,1,0,1,1,0,0,0,0,0,0,0,0,0,0,0,1,1,0,1,1,1,1,1,1},
            {1,1,1,1,1,1,1,0,1,1,0,1,1,1,1,1,1,1,1,1,0,1,1,0,1,1,1,1,1,1},
            {0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0},
            {1,1,1,1,1,1,1,0,1,1,0,1,1,0,1,1,1,0,1,1,0,1,1,0,1,1,1,1,1,1},
            {1,1,1,1,1,1,1,0,1,1,0,0,0,0,0,0,0,0,0,0,0,1,1,0,1,1,1,1,1,1},
            {1,1,1,1,1,1,1,0,1,1,0,1,1,1,1,1,1,1,1,1,0,1,1,0,1,1,1,1,1,1},
            {1,1,1,1,1,1,1,0,1,1,0,1,1,1,1,1,1,1,1,1,0,1,1,0,1,1,1,1,1,1},
            {1,1,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,1,0,1,1,1,1,0,1,1,1,1,1,0,1,1,1,0,1,1,1,1,1,0,1,1,1,1,0,1},
            {1,1,0,1,1,1,1,0,1,1,1,1,1,0,1,1,1,0,1,1,1,1,1,0,1,1,1,1,0,1},
            {1,1,0,0,0,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,0,0,0,1},
            {1,1,1,1,0,1,1,0,1,1,0,1,1,1,1,1,1,1,1,1,0,1,1,0,1,1,0,1,1,1},
            {1,1,1,1,0,1,1,0,1,1,0,1,1,1,1,1,1,1,1,1,0,1,1,0,1,1,0,1,1,1},
            {1,1,0,0,0,0,0,0,1,1,0,0,0,0,1,1,1,0,0,0,0,1,1,0,0,0,0,0,0,1},
            {1,1,0,1,1,1,1,1,1,1,1,1,1,0,1,1,1,0,1,1,1,1,1,1,1,1,1,1,0,1},
            {1,1,0,1,1,1,1,1,1,1,1,1,1,0,1,1,1,0,1,1,1,1,1,1,1,1,1,1,0,1},
            {1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}
    };

    public static int[,] wallsLevelTwo =
    {
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1},
            {1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,1,0,1,1,1,1,1,1,1,1,1,1,0,1,1,1,0,1,1,1,1,1,1,1,1,1,1,0,1},
            {1,1,0,1,0,0,0,0,0,0,0,0,1,0,1,1,1,0,1,0,0,0,0,0,0,0,0,1,0,1},
            {1,1,0,1,1,1,1,1,1,1,0,1,1,0,1,1,1,0,1,1,0,1,1,1,1,1,1,1,0,1},
            {1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,1,0,1,1,1,1,0,1,1,0,1,1,1,1,1,1,1,1,1,0,1,1,0,1,1,1,1,0,1},
            {1,1,0,1,1,1,1,0,1,1,0,1,1,1,1,1,1,1,1,1,0,1,1,0,1,1,1,1,0,1},
            {1,1,0,0,0,0,0,0,1,1,0,0,0,0,1,1,1,0,0,0,0,1,1,0,0,0,0,0,0,1},
            {1,1,1,1,1,1,1,0,1,1,1,1,1,0,1,1,1,0,1,1,1,1,1,0,1,1,1,1,1,1},
            {1,1,1,1,1,1,1,0,1,1,1,1,1,0,1,1,1,0,1,1,1,1,1,0,1,1,1,1,1,1},
            {1,1,1,1,1,1,1,0,1,1,0,0,0,0,0,0,0,0,0,0,0,1,1,0,1,1,1,1,1,1},
            {1,1,1,1,1,1,1,0,1,1,0,1,1,1,1,1,1,1,1,1,0,1,1,0,1,1,1,1,1,1},
            {0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0},
            {1,1,1,1,1,1,1,0,1,1,0,1,1,0,1,1,1,0,1,1,0,1,1,0,1,1,1,1,1,1},
            {1,1,1,1,1,1,1,0,1,1,0,0,0,0,0,0,0,0,0,0,0,1,1,0,1,1,1,1,1,1},//15
            {1,1,1,1,1,1,1,0,1,1,0,1,1,1,1,1,1,1,1,1,0,1,1,0,1,1,1,1,1,1},
            {1,1,1,1,1,1,1,0,1,1,0,1,1,1,1,1,1,1,1,1,0,1,1,0,1,1,1,1,1,1},
            {1,1,0,0,0,1,1,0,0,0,0,0,0,0,1,1,1,0,0,0,0,0,0,0,1,1,0,0,0,1},
            {1,1,0,1,1,1,1,0,1,1,1,1,1,0,1,1,1,0,1,1,1,1,1,0,1,1,1,1,0,1},
            {1,1,0,1,1,1,1,0,1,1,1,1,1,0,1,1,1,0,1,1,1,1,1,0,1,1,1,1,0,1},
            {1,1,0,0,0,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,0,0,0,1},//21
            {1,1,1,1,0,1,1,1,1,1,0,1,1,1,1,1,1,1,1,1,0,1,1,1,1,1,0,1,1,1},
            {1,1,1,1,0,1,1,0,1,1,0,1,1,1,1,1,1,1,1,1,0,1,1,0,1,1,0,1,1,1},
            {1,1,0,0,0,0,0,0,1,1,0,0,0,0,1,1,1,0,0,0,0,1,1,0,0,0,0,0,0,1},
            {1,1,0,1,1,1,1,1,1,1,1,1,1,0,1,1,1,0,1,1,1,1,1,1,1,1,1,1,0,1},
            {1,1,0,1,1,1,1,1,1,1,1,1,1,0,1,1,1,0,1,1,1,1,1,1,1,1,1,1,0,1},
            {1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1}
    };
}

