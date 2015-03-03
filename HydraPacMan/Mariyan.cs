using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

class Mariyan
{
    public static void GameOutro()
    {
        Console.SetCursorPosition(5, 15);
        Console.WriteLine(@" ┌─────────────────────────────────────┐
      │                                     │
      │           Congratulations!          │
      │    You passed the terrors of C#!    │
      │                                     │
      └─────────────────────────────────────┘");

        int col = 5;
        int row = 14;
        bool right = true;
        bool down = false;
        bool left = false;
        bool up = false;
        int counter = 0;

        while (true)
        {
            Thread.Sleep(400);

            if (col == 46 && row == 14)
            {
                right = false;
                down = true;
                counter = 0;
            }

            if (row == 21 && col == 46)
            {
                down = false;
                left = true;
                counter = 0;
            }

            if (col == 5 && row == 21)
            {
                left = false;
                up = true;
                counter = 0;
            }

            if (row == 14 && col == 5)
            {
                up = false;
                right = true;
                counter = 0;
            }

            if (right)
            {
                col++;
                Console.SetCursorPosition(col - 1, row);
                Console.Write(" ");
                Console.SetCursorPosition(col, row);
                if (col % 2 == 0) Console.Write("<");
                else Console.Write("-");

                if (col > 41) counter++;

                if (counter > 4)
                {
                    Console.SetCursorPosition(col + 1 - counter + 4, row + counter - 4);
                    Console.Write(" ");
                }
                else
                {
                    Console.SetCursorPosition(col + 1, row);
                    Console.Write(" ");
                }

                if (counter > 3)
                {
                    Console.SetCursorPosition(col + 2 - counter + 3, row + counter - 3);
                    Console.Write("Д");
                }
                else
                {
                    Console.SetCursorPosition(col + 2, row);
                    Console.Write("Д");
                }

                if (counter > 2)
                {
                    Console.SetCursorPosition(col + 3 - counter + 2, row + counter - 2);
                    Console.Write("И");
                }
                else
                {
                    Console.SetCursorPosition(col + 3, row);
                    Console.Write("И");
                }
                if (counter > 1)
                {
                    Console.SetCursorPosition(col + 4 - counter + 1, row + counter - 1);
                    Console.Write("Н");
                }
                else
                {
                    Console.SetCursorPosition(col + 4, row);
                    Console.Write("Н");
                }
                if (counter > 0)
                {
                    Console.SetCursorPosition(col + 5 - counter, row + counter);
                    Console.Write("Е");
                }
                else
                {
                    Console.SetCursorPosition(col + 5, row);
                    Console.Write("Е");
                }

            }
            else if (down)
            {
                row++;
                Console.SetCursorPosition(col, row - 1);
                Console.Write(" ");
                Console.SetCursorPosition(col, row);
                if (row % 2 == 0) Console.Write("^");
                else Console.Write(":");

                if (row <= 16)
                {
                    Console.SetCursorPosition(col, row + 1);
                    Console.Write(" ");
                    Console.SetCursorPosition(col, row + 2);
                    Console.Write("Д");
                    Console.SetCursorPosition(col, row + 3);
                    Console.Write("И");
                    Console.SetCursorPosition(col, row + 4);
                    Console.Write("Н");
                    Console.SetCursorPosition(col, row + 5);
                    Console.Write("Е");
                }
                else
                {
                    counter++;
                    if (counter > 0)
                    {
                        Console.SetCursorPosition(col - counter, row + 5 - counter);
                        Console.Write("Е");
                    }
                    if (counter > 1)
                    {
                        Console.SetCursorPosition(col - counter + 1, row + 4 - counter + 1);
                        Console.Write("Н");
                    }
                    if (counter > 2)
                    {
                        Console.SetCursorPosition(col - counter + 2, row + 3 - counter + 2);
                        Console.Write("И");
                    }
                    if (counter > 3)
                    {
                        Console.SetCursorPosition(col - counter + 3, row + 2 - counter + 3);
                        Console.Write("Д");
                    }
                    if (counter > 4)
                    {
                        Console.SetCursorPosition(col - counter + 4, row + 1 - counter + 4);
                        Console.Write(" ");
                    }
                }


            }
            else if (left)
            {
                col--;
                Console.SetCursorPosition(col + 1, row);
                Console.Write(" ");
                Console.SetCursorPosition(col, row);
                if (col % 2 == 0) Console.Write(">");
                else Console.Write("-");

                if (col > 9)
                {
                    Console.SetCursorPosition(col - 1, row);
                    Console.Write(" ");
                    Console.SetCursorPosition(col - 2, row);
                    Console.Write("Д");
                    Console.SetCursorPosition(col - 3, row);
                    Console.Write("И");
                    Console.SetCursorPosition(col - 4, row);
                    Console.Write("Н");
                    Console.SetCursorPosition(col - 5, row);
                    Console.Write("Е");
                }
                else
                {
                    counter++;
                    if (counter > 4)
                    {
                        Console.SetCursorPosition(col - 1 + counter - 4, row - counter + 4);
                        Console.Write(" ");
                    }
                    if (counter > 3)
                    {
                        Console.SetCursorPosition(col - 2 + counter - 3, row - counter + 3);
                        Console.Write("Д");
                    }
                    if (counter > 2)
                    {
                        Console.SetCursorPosition(col - 3 + counter - 2, row - counter + 2);
                        Console.Write("И");
                    }
                    if (counter > 1)
                    {
                        Console.SetCursorPosition(col - 4 + counter - 1, row - counter + 1);
                        Console.Write("Н");
                    }
                    if (counter > 0)
                    {
                        Console.SetCursorPosition(col - 5 + counter, row - counter);
                        Console.Write("Е");
                    }
                }
            }
            else if (up)
            {
                row--;
                Console.SetCursorPosition(col, row + 1);
                Console.Write(" ");
                Console.SetCursorPosition(col, row);
                if (row % 2 == 0) Console.Write("v");
                else Console.Write(":");

                if (row >= 19)
                {
                    Console.SetCursorPosition(col, row - 1);
                    Console.Write(" ");
                    Console.SetCursorPosition(col, row - 2);
                    Console.Write("Д");
                    Console.SetCursorPosition(col, row - 3);
                    Console.Write("И");
                    Console.SetCursorPosition(col, row - 4);
                    Console.Write("Н");
                    Console.SetCursorPosition(col, row - 5);
                    Console.Write("Е");
                }
                else
                {
                    counter++;
                    if (counter > 0)
                    {
                        Console.SetCursorPosition(col + counter, row - 5 + counter);
                        Console.Write("Е");
                    }
                    if (counter > 1)
                    {
                        Console.SetCursorPosition(col + counter - 1, row - 4 + counter - 1);
                        Console.Write("Н");
                    }
                    if (counter > 2)
                    {
                        Console.SetCursorPosition(col + counter - 2, row - 3 + counter - 2);
                        Console.Write("И");
                    }
                    if (counter > 3)
                    {
                        Console.SetCursorPosition(col + counter - 3, row - 2 + counter - 3);
                        Console.Write("Д");
                    }
                    if (counter > 4)
                    {
                        Console.SetCursorPosition(col + counter - 4, row - 1 + counter - 4);
                        Console.Write(" ");
                    }
                }
            }
        }
    }

    public static int[,] monsterDCoordinatesLevelOne = new int[,] 
        {
            {20, 2},    
            {20, 3},
            {20, 4},
            {20, 5},    
            {19, 5},
            {18, 5},
            {17, 5},
            {17, 4},
            {17, 3},
            {17, 2},
            {17, 1},
            {18, 1},
            {19, 1},
            {20, 1},
            {21, 1},
            {22, 1},
            {23, 1},
            {23, 2},
            {23, 3},
            {23, 4},
            {23, 5},
            {24, 5},
            {25, 5},
            {26, 5},
            {27, 5},
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
            {20, 6},
            {20, 7},
            {20, 8},
            {19, 8},
            {18, 8},
            {17, 8},
            {17, 9},
            {17, 10},
            {17, 11},
            {16, 11},
            {15, 11},
            {14, 11},
            {13, 11},
            {12, 11},
            {11, 11},
            {10, 11},
            {10, 12},
            {10, 13},
            {09, 13},
            {08, 13},
            {07, 13},
            {06, 13},
            {05, 13},
            {04, 13},
            {03, 13},
            {02, 13},
            {01, 13},
            {00, 13},
            {29, 13},
            {28, 13},
            {27, 13},
            {26, 13},
            {25, 13},
            {24, 13},
            {23, 13},
            {23, 12},
            {23, 11},
            {23, 10},
            {23, 09},
            {23, 08},
            {24, 08},
            {25, 08},
            {26, 08},
            {27, 08},
            {28, 08},
            {28, 07},
            {28, 06},
            {28, 05},
            {28, 04},
            {28, 03},
            {28, 02},
            {28, 01},
            {27, 01},
            {26, 01},
            {25, 01},
            {24, 01},
            {23, 01},
            {23, 02},
            {23, 03},
            {23, 04},
            {23, 05},
            {22, 05},
            {21, 05},
        };

    public static void MonsterDLevelOne()
    {
        PackManHydra.badGuysCoordinates[4, 0] = PackManHydra.badGuysCoordinates[4, 2];
        PackManHydra.badGuysCoordinates[4, 1] = PackManHydra.badGuysCoordinates[4, 3];
        PackManHydra.badGuysCoordinates[4, 2] = monsterDCoordinatesLevelOne[PackManHydra.GadFourCounter, 0];
        PackManHydra.badGuysCoordinates[4, 3] = monsterDCoordinatesLevelOne[PackManHydra.GadFourCounter, 1];
        if (PackManHydra.GadFourCounter == monsterDCoordinatesLevelOne.GetLength(0) - 1)
        {
            PackManHydra.GadFourCounter = 3;
        }
        else
        {
            PackManHydra.GadFourCounter++;
        }
        PackManHydra.badGuysCoordinates[4, 2] = monsterDCoordinatesLevelOne[PackManHydra.GadFourCounter, 0];
        PackManHydra.badGuysCoordinates[4, 3] = monsterDCoordinatesLevelOne[PackManHydra.GadFourCounter, 1];
    }

    public static void MonsterILevelTwo()
    {
        PackManHydra.badGuysCoordinates[3, 0] = PackManHydra.badGuysCoordinates[3, 2];
        PackManHydra.badGuysCoordinates[3, 1] = PackManHydra.badGuysCoordinates[3, 3];
        PackManHydra.badGuysCoordinates[3, 2] = monsterICoordinatesLevelTwo[PackManHydra.GadThreeCounter, 0];
        PackManHydra.badGuysCoordinates[3, 3] = monsterICoordinatesLevelTwo[PackManHydra.GadThreeCounter, 1];
        if (PackManHydra.GadThreeCounter == monsterICoordinatesLevelTwo.GetLength(0) - 1)
        {
            PackManHydra.GadThreeCounter = 5;
        }
        else
        {
            PackManHydra.GadThreeCounter++;
        }
        PackManHydra.badGuysCoordinates[3, 2] = monsterICoordinatesLevelTwo[PackManHydra.GadThreeCounter, 0];
        PackManHydra.badGuysCoordinates[3, 3] = monsterICoordinatesLevelTwo[PackManHydra.GadThreeCounter, 1];
    }

    public static int[,] monsterICoordinatesLevelTwo = new int[, ] 
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

