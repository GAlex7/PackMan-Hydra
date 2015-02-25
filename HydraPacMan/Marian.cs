using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Marian
{
    // Гад 4 - > W

    public static void MonsterW()
    {
        PackManHydra.badGuysCoordinates[4, 0] = PackManHydra.badGuysCoordinates[4, 2];
        PackManHydra.badGuysCoordinates[4, 1] = PackManHydra.badGuysCoordinates[4, 3];
        PackManHydra.badGuysCoordinates[4, 2] = PackManHydra.monsterW[PackManHydra.GadFourCounter, 0];
        PackManHydra.badGuysCoordinates[4, 3] = PackManHydra.monsterW[PackManHydra.GadFourCounter, 1];
        if (PackManHydra.GadFourCounter == 101)
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
}

