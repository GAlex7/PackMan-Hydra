using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Evgeni
{
    public static int[,] monsterDCoordinatesLevelTwo = new int[,] 
        {
            {20, 3},    
            {20, 4},
            {20, 5},
            {20, 6},
            {20, 7},
            {20, 8},
            {19, 8},
            {18, 8},
            {17, 8},
            {17, 9},
            {17, 10},
            {17, 11},
            {18, 11},
            {19, 11},
            {20, 11},
            {20, 12},
            {20, 13},
            {21, 13},
            {22, 13},
            {23, 13},
            {24, 13},
            {25, 13},
            {26, 13},
            {27, 13},
            {28, 13},
            {29, 13},
            {15, 0},
            {15, 1},
            {16, 1},
            {17, 1},
            {18, 1},
            {19, 1},
            {20, 1},
            {21, 1},
            {22, 1},
            {23, 1},
            {24, 1},
            {25, 1},
            {26, 1},
            {27, 1},
            {28, 1},
            {28, 2},
            {28, 3},
            {28, 4},
            {28, 5},
            {28, 6},
            {28, 7},
            {28, 8},
            {27, 8},
            {26, 8},
            {25, 8},
            {24, 8},
            {23, 8},
            {23, 7},
            {23, 6},
            {23, 5},
            {22, 5},
            {21, 5},
            {20, 5},
        };

    public static void MonsterDMovingLevelTwo()
    {
        PackManHydra.badGuysCoordinates[4, 0] = PackManHydra.badGuysCoordinates[4, 2];
        PackManHydra.badGuysCoordinates[4, 1] = PackManHydra.badGuysCoordinates[4, 3];
        PackManHydra.badGuysCoordinates[4, 2] = monsterDCoordinatesLevelTwo[PackManHydra.GadFourCounter, 0];
        PackManHydra.badGuysCoordinates[4, 3] = monsterDCoordinatesLevelTwo[PackManHydra.GadFourCounter, 1];
        if (PackManHydra.GadFourCounter == 57)
        {
            PackManHydra.GadFourCounter = 2;
        }
        else
        {
            PackManHydra.GadFourCounter++;
        }
        PackManHydra.badGuysCoordinates[4, 2] = monsterDCoordinatesLevelTwo[PackManHydra.GadFourCounter, 0];
        PackManHydra.badGuysCoordinates[4, 3] = monsterDCoordinatesLevelTwo[PackManHydra.GadFourCounter, 1];
    }
}

