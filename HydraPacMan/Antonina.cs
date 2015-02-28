using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


class Antonina
{
    public static int[,] monsterECoordinatesLevelOne = new int[,]
    {           
                {10,4},
                {10,5},
                {9,5},
                {8,5},
                {7,5},
                {6,5},
                {5,5},
                {4,5},
                {3,5},
                {2,5},
                {2,6},
                {2,7},
                {2,8},
                {3,8}, 
                {4,8},
                {5,8},
                {6,8},
                {7,8},
                {7,7},
                {7,6}, 
                {7,5},
                {7,4},
                {7,3},
                {7,2},
                {7,1},
                {6,1},
                {5,1},
                {4,1},
                {3,1},
                {2,1},
                {2,2},
                {2,3},
                {2,4},
                {2,5},
                {2,5},
                {3,5},
                {4,5},
                {5,5},
                {6,5},
                {7,5},
                {8,5},
                {9,5},
                {10,5},
                {11,5},
                {12,5},
                {13,4},
                {13,3},
                {13,2},
                {13,1},
                {12,1},
                {11,1},
                {10,1},
                {9,1},
                {8,1},
                {7,1},
                {7,2},
                {7,3},
                {7,4},
                {7,5},
                {8,5},
                {9,5},
                {10,4},
    
    };

        public static void monsterEMovingLevelOne()
        {
            PackManHydra.badGuysCoordinates[2, 0] = PackManHydra.badGuysCoordinates[2,2];
            PackManHydra.badGuysCoordinates[2, 1] = PackManHydra.badGuysCoordinates[2,3];

            PackManHydra.badGuysCoordinates[2, 2] = monsterECoordinatesLevelOne[PackManHydra.GadTwoCounter, 0];
            PackManHydra.badGuysCoordinates[2, 3] = monsterECoordinatesLevelOne[PackManHydra.GadTwoCounter, 1];

            if (PackManHydra.GadTwoCounter == monsterECoordinatesLevelOne.GetLength(0) - 1)
            {
                PackManHydra.GadTwoCounter = 1;
            }
                else
            {

                PackManHydra.GadTwoCounter++;
            }

            PackManHydra.badGuysCoordinates[2, 2] = monsterECoordinatesLevelOne[PackManHydra.GadTwoCounter, 0];
            PackManHydra.badGuysCoordinates[2, 3] = monsterECoordinatesLevelOne[PackManHydra.GadTwoCounter, 1];
         
        }
 
    public static void HydraTeam()
     {
         Console.WindowHeight = 50;
         Console.WindowHeight = 25;
         Console.Clear();
         Console.SetCursorPosition(0, 0);
         Console.CursorVisible = false;
         Console.ForegroundColor = ConsoleColor.Red;
         Console.WriteLine("___           A.Yankova ");
         Console.WriteLine(" ___           V.Vasilev ");
         Console.WriteLine("                G.Grozdanchev");
         Console.WriteLine("   HYDRA         D.Dzhurenov");
         Console.WriteLine("                  D.Piskov");
         Console.WriteLine("     TEAM          E.Krustev");
         Console.WriteLine("      ___           I.Bonchev");
         Console.WriteLine("       ___           M.Draganov");
         for (int i = 0; i < 15; i++)
         {
             Thread.Sleep(150);
             Console.MoveBufferArea(i + 31, i, 31, 8, i + 40, i + 1);
             Console.MoveBufferArea(i, i, 31, 8, i + 1, i + 1);
             Console.Beep((i + 10) * 100, 200);
         }
         Console.SetCursorPosition(0, 23);
         Console.ResetColor();
     }
    }


