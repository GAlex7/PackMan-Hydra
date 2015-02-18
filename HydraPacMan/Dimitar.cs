using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Dimitar
{
    // Гад 3 - > Z

    struct PositionZ
    {
        public int Row;
        public int Col;

        public PositionZ(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }
    }
    public static void BadGuyZ(int[,] BadGuysCoordinates)
    {
        PositionZ[] positon = 
        { 
            new PositionZ(13, 14), 
            new PositionZ(11, 14), 
            new PositionZ(11, 11),
            new PositionZ(18, 11),
            new PositionZ(18, 2),
            new PositionZ(21, 2),
            new PositionZ(21, 4),
            new PositionZ(24, 4),
            new PositionZ(24, 7),
            new PositionZ(21, 7),
            new PositionZ(21, 13),
            new PositionZ(18, 13),
            new PositionZ(18, 10),
            new PositionZ(15, 10),
            new PositionZ(15, 21),
            new PositionZ(11, 21),
            new PositionZ(11, 14),

        };
    }
}

