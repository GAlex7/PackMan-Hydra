using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


class Antonina
{
    // Гад 2 -> Q4

    public static int[,] badGuysCoordinates = new int[5, 4];
    struct Position
    {
        public int row;
        public int col;
        public Position(int row, int col)
        {
            this.row = row;
            this.col = col;
        }
    }

      public static void BadGuyQ()
        {
            Position[] availablePositions = new Position[]
    {        
                new Position(3,10),
                new Position(4,10),
                new Position(5,10),
                new Position(5,9),
                new Position(5,8),
                new Position(5,7),
                new Position(5,6),
                new Position(5,5),
                new Position(5,4),
                new Position(5,3),
                new Position(5,2),
                new Position(6,2),
                new Position(7,2),
                new Position(8,2), 
                new Position(8,3),
                new Position(8,4),
                new Position(8,5),
                new Position(8,6),
                new Position(8,7), 
                new Position(7,7),
                new Position(6,7),
                new Position(4,7),
                new Position(3,7),
                new Position(2,7),
                new Position(1,7),
                new Position(1,6),
                new Position(1,5),
                new Position(1,4),
                new Position(1,3),
                new Position(1,2),
                new Position(2,2),
                new Position(3,2),
                new Position(4,2),
                new Position(5,2),
                new Position(5,3),
                new Position(5,4),
                new Position(5,5),
                new Position(5,6),
                new Position(5,7),
                new Position(5,8),
                new Position(5,9),
                new Position(5,10),
                new Position(5,11),
                new Position(5,12),
                new Position(5,13),
                new Position(4,13),
                new Position(3,13),
                new Position(2,13),
                new Position(1,13),
                new Position(1,12),
                new Position(1,11),
                new Position(1,10),
                new Position(1,9),
                new Position(1,8),
                new Position(1,7),
                new Position(2,7),
                new Position(3,7),
                new Position(4,7),
                new Position(5,7),
                new Position(5,8),
                new Position(5,9),
    
    };
            //Position[] dots = availablePositions;
            Console.SetCursorPosition(3, 10);
            Console.CursorVisible = false;
            Queue<Position> gadinka = new Queue<Position>();

            gadinka.Enqueue(new Position(3, 10));

            //while (true)
            //{
            //  foreach (Position position in availablePositions)
            // {
            int count = 0;
            //Thread.Sleep(200);

            //gadinka.Enqueue(position);
            //Console.SetCursorPosition(availablePositions[count].col, availablePositions[count].row);
            //Console.ForegroundColor = ConsoleColor.Cyan;
            gadinka.Enqueue(availablePositions[count]);
            badGuysCoordinates[2, 0] = availablePositions[count].col;
            badGuysCoordinates[2, 1] = availablePositions[count].row;
            //Console.Write("Q");
            Position lastGad = gadinka.Dequeue();
            badGuysCoordinates[2, 2] = lastGad.col;
            badGuysCoordinates[2, 3] = lastGad.row;
            //Console.SetCursorPosition(lastGad.col, lastGad.row);
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine(".");
            count++;
            if (count==availablePositions.Length)
            {
                count = 0;
            }
            
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


