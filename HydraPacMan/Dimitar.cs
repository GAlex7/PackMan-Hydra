using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Dimitar
{
    // Гад 3 - > Z

    public static void MonsterZ()
    {
        PackManHydra.badGuysCoordinates[3, 0] = PackManHydra.badGuysCoordinates[3, 2];
        PackManHydra.badGuysCoordinates[3, 1] = PackManHydra.badGuysCoordinates[3, 3];
        PackManHydra.badGuysCoordinates[3, 2] = PackManHydra.monsterZ[PackManHydra.GadThreeCounter, 0];
        PackManHydra.badGuysCoordinates[3, 3] = PackManHydra.monsterZ[PackManHydra.GadThreeCounter, 1];
        if (PackManHydra.GadThreeCounter == 85)
        {
            PackManHydra.GadThreeCounter = 6;
        }
        else
        {
            PackManHydra.GadThreeCounter++;
        }
        PackManHydra.badGuysCoordinates[3, 2] = PackManHydra.monsterZ[PackManHydra.GadThreeCounter, 0];
        PackManHydra.badGuysCoordinates[3, 3] = PackManHydra.monsterZ[PackManHydra.GadThreeCounter, 1];

    }

}

