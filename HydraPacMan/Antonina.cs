using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


class Antonina
{
    // Гад 2 -> Q4

        public static void BadGuyQ()
        {
            PackManHydra.badGuysCoordinates[2, 0] = PackManHydra.badGuysCoordinates[2,2];
            PackManHydra.badGuysCoordinates[2, 1] = PackManHydra.badGuysCoordinates[2,3];
            
            PackManHydra.badGuysCoordinates[2, 2] = PackManHydra.availablePositionsGuyQ[PackManHydra.GadTwoCounter, 0];
            PackManHydra.badGuysCoordinates[2, 3] = PackManHydra.availablePositionsGuyQ[PackManHydra.GadTwoCounter, 1];
            
            if (PackManHydra.GadTwoCounter==PackManHydra.availablePositionsGuyQ.GetLength(0)-1)
            {
                PackManHydra.GadTwoCounter = 1;
            }
                else
            {

                PackManHydra.GadTwoCounter++;
            }

            PackManHydra.badGuysCoordinates[2, 2] = PackManHydra.availablePositionsGuyQ[PackManHydra.GadTwoCounter, 0];
            PackManHydra.badGuysCoordinates[2, 3] = PackManHydra.availablePositionsGuyQ[PackManHydra.GadTwoCounter, 1];
         
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


