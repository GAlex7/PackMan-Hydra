using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;

class PackManHydra
{
    public const int windowWidth = 31;
    public const int windowHeight = 33;
    public static string ourGuy = "X<>^vx--::";
    public static string badGuys = "xНЕИД";

    public static string[] colors = { "Yellow", "Green", "White", "Magenta", "Cyan" };
    public static int[,] badGuysCoordinates = new int[5, 4];
    public static int[,] smallAndBigDots = new int[29, 30];

    public static bool endGame = true;
    public static bool endLevelOne = true;
    public static bool endLevelTwo = true;
    public static int points = 0;
    public static int lives = 3;
    public static int direction; // by GA
    // public static int[,] dots;   // GAlex
    public static int GadOneCounter = 0;
    public static int GadTwoCounter = 0;
    public static int GadThreeCounter = 0;
    public static int GadFourCounter = 0;

    //private static string gameSounds = Directory.GetCurrentDirectory();

    //Ивайло
    public static int[,] monsterArray = new int[57, 2] 
        {
            {18, 15},    
            {19, 15},
            {20, 15},
            {20, 16},
            {20, 17},
            {20, 18},
            {19, 18},
            {18, 18},
            {17, 18},
            {17, 19},
            {17, 20},
            {17, 21},
            {18, 21},
            {19, 21},
            {20, 21},
            {20, 22},
            {20, 23},
            {20, 24},
            {19, 24},
            {18, 24},
            {17, 24},
            {17, 25},
            {17, 26},
            {17, 27},
            {18, 27},
            {19, 27},
            {20, 27},
            {21, 27},
            {22, 27},
            {23, 27},
            {24, 27},
            {25, 27},
            {26, 27},
            {27, 27},
            {28, 27},
            {28, 26},
            {28, 25},
            {28, 24},
            {27, 24},
            {26, 24},
            {26, 23},
            {26, 22},
            {26, 21},
            {27, 21},
            {28, 21},
            {28, 20},
            {28, 19},
            {28, 18},
            {27, 18},
            {26, 18},
            {25, 18},
            {24, 18},
            {23, 18},
            {22, 18},
            {21, 18},
            {20, 18},
            {19, 18},
        };

    // Димитър Стоянов
    public static int[,] monsterZ = new int[86, 2] 
        {
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

    //Мариян
    public static int[,] monsterW = new int[102, 2] 
        {
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
            {29, 13}, //
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

    private static string gameSounds = Directory.GetCurrentDirectory();

    static void Main()
    {
        // Заглавие на конзолата
        Console.Title = "PacMan";
        InitDotsArray();                               //GAlex
        // Задаваме encoding за гадовете
        Console.OutputEncoding = Encoding.UTF8;

        // Задаваме размер на конзолата
        badGuysCoordinates[0, 0] = 15; //Console.WindowHeight = windowHeight;
        badGuysCoordinates[0, 1] = 21; //Console.WindowWidth = windowWidth;
        //Console.BufferHeight = Console.WindowHeight;
        //Console.BufferWidth = Console.WindowWidth;

        // Фонова музика
        //SoundPlayer player = new SoundPlayer();
        SoundPlayer player = new SoundPlayer();

        // Принтиране на логото, изчакване за натискане на клавиш преди преминаване напред

        DrawLogo(20);
        Console.ReadKey();
        Console.Clear();


        // Меню: 1.New Game, 2.Load Game, 3.Score, 4.Exit

        Ivaylo.PrintingMenuGame();
        Console.ReadKey();
        Console.Clear();


        // Изчистваме конзолата
        //Console.Clear();
        Console.CursorVisible = false; // и скриваме курсора да не ни мига...    

        // Принтиране на логото, изчакване за натискане на клавиш преди преминаване напред
        // Ако е натиснато 1 -> чертаем лабиринта и на мястото на  READY да има брояч -> 3, 2, 1 (сменят се) -> GO

        DrawGameBoard();
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

        player.SoundLocation = gameSounds + @"\sounds\ThemeSong.wav";
        player.Load();
        player.Play();

        while (true)
        {
            Thread.Sleep(150);
            player.SoundLocation = gameSounds + @"\sounds\ThemeSong.wav";
            player.Load();
            player.Play();

            while (true)
            {
                Thread.Sleep(200);
                // Викане на нашето човече
                // Викане на гадовете от класове

                // Викане на нашето човече
                Ivaylo.MonsterM();
                Dimitar.MonsterZ();
                Marian.MonsterW();
                // Обновяване на екрана

                Georgi.RefreshScreen(badGuysCoordinates);

                // 

            }
        }
    }


    private static void DrawGameBoard()
    {
        Console.WriteLine(" ┌────────────┐ ┌────────────┐");
        Console.WriteLine(" │............│ │............│");
        Console.WriteLine(" │.┌──┐.┌───┐.│ │.┌───┐.┌──┐.│");
        Console.WriteLine(" │.│  │.│ Q │.│ │.│ W │.│  │.│");
        Console.WriteLine(" │о└──┘.└┘─└┘.└─┘.└┘─└┘.└──┘о│");
        Console.WriteLine(" │...........................│");
        Console.WriteLine(" │.┌──┐.┌┐.┌───────┐.┌┐.┌──┐.│");
        Console.WriteLine(" │.└──┘.││.└──┐ ┌──┘.││.└──┘.│");
        Console.WriteLine(" │......││....│ │....││......│");
        Console.WriteLine(" └────┐.│└──┐ │ │ ┌──┘│.┌────┘");
        Console.WriteLine("      │.│┌──┘ └─┘ └──┐│.│     ");
        Console.WriteLine("      │.││           ││.│     ");
        Console.WriteLine("──────┘.└┘ ┌───────┐ └┘.└─────");
        Console.WriteLine("       .   │ Z   M │   .      ");
        Console.WriteLine("──────┐.┌┐ └┘─└─┘─└┘ ┌┐.┌─────");
        Console.WriteLine("      │.││   READY!  ││.│     ");
        Console.WriteLine("      │.││ ┌───────┐ ││.│     ");
        Console.WriteLine(" ┌────┘.└┘ └──┐ ┌──┘ └┘.└────┐");
        Console.WriteLine(" │............│ │............│");
        Console.WriteLine(" │.┌──┐.┌───┐.│ │.┌───┐.┌──┐.│");
        Console.WriteLine(" │.└─┐│.└───┘.└─┘.└───┘.│┌─┘.│");
        Console.WriteLine(" │о..││....... X .......││..о│");
        Console.WriteLine(" └─┐.││.┌┐.┌───────┐.┌┐.││.┌─┘");
        Console.WriteLine(" ┌─┘.└┘.││.└──┐ ┌──┘.││.└┘.└─┐");
        Console.WriteLine(" │......││....│ │....││......│");
        Console.WriteLine(" │.┌────┘└──┐.│ │.┌──┘└────┐.│");
        Console.WriteLine(" │.└────────┘.└─┘.└────────┘.│");
        Console.WriteLine(" │...........................│");
        Console.WriteLine(" └───────────────────────────┘");
    }

    public static int[,] walls =
    {
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
            {1,1,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,1,0,1,1,1,1,0,1,1,1,1,1,0,1,1,1,0,1,1,1,1,1,0,1,1,1,1,0,1},
            {1,1,0,1,1,1,1,0,1,1,1,1,1,0,1,1,1,0,1,1,1,1,1,0,1,1,1,1,0,1},
            {1,1,0,1,1,1,1,0,1,1,1,1,1,0,1,1,1,0,1,1,1,1,1,0,1,1,1,1,0,1},
            {1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,1,0,1,1,1,1,0,1,1,0,1,1,1,1,1,1,1,1,1,0,1,1,0,1,1,1,1,0,1},
            {1,1,0,1,1,1,1,0,1,1,0,1,1,1,1,1,1,1,1,1,0,1,1,0,1,1,1,1,0,1},
            {1,1,0,0,0,0,0,0,1,1,0,0,0,0,1,1,1,0,0,0,0,1,1,0,0,0,0,0,0,1},
            {1,1,1,1,1,1,1,0,1,1,1,1,1,0,1,1,1,0,1,1,1,1,1,0,1,1,1,1,1,1},
            {1,1,1,1,1,1,1,0,1,1,1,1,1,0,1,1,1,0,1,1,1,1,1,0,1,1,1,1,1,1},
            {1,1,1,1,1,1,1,0,1,1,0,0,0,0,0,0,0,0,0,0,0,1,1,0,1,1,1,1,1,1},
            {1,1,1,1,1,1,1,0,1,1,0,1,1,1,1,1,1,1,1,1,0,1,1,0,1,1,1,1,1,1},
            {0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0},
            {1,1,1,1,1,1,1,0,1,1,0,1,1,1,1,1,1,1,1,1,0,1,1,0,1,1,1,1,1,1},
            {1,1,1,1,1,1,1,0,1,1,0,0,0,0,0,0,0,0,0,0,0,1,1,0,1,1,1,1,1,1},//15
            {1,1,1,1,1,1,1,0,1,1,0,1,1,1,1,1,1,1,1,1,0,1,1,0,1,1,1,1,1,1},
            {1,1,1,1,1,1,1,0,1,1,0,1,1,1,1,1,1,1,1,1,0,1,1,0,1,1,1,1,1,1},
            {1,1,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,1,0,1,1,1,1,0,1,1,1,1,1,0,1,1,1,0,1,1,1,1,1,0,1,1,1,1,0,1},
            {1,1,0,1,1,1,1,0,1,1,1,1,1,0,1,1,1,0,1,1,1,1,1,0,1,1,1,1,0,1},
            {1,1,0,0,0,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,0,0,0,1},//21
            {1,1,1,1,0,1,1,0,1,1,0,1,1,1,1,1,1,1,1,1,0,1,1,0,1,1,0,1,1,1},
            {1,1,1,1,0,1,1,0,1,1,0,1,1,1,1,1,1,1,1,1,0,1,1,0,1,1,0,1,1,1},
            {1,1,0,0,0,0,0,0,1,1,0,0,0,0,1,1,1,0,0,0,0,1,1,0,0,0,0,0,0,1},
            {1,1,0,1,1,1,1,1,1,1,1,1,1,0,1,1,1,0,1,1,1,1,1,1,1,1,1,1,0,1},
            {1,1,0,1,1,1,1,1,1,1,1,1,1,0,1,1,1,0,1,1,1,1,1,1,1,1,1,1,0,1},
            {1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}
    };

    private static void DrawLogo(int n)
    {
        int centerR = n / 2;
        int centerC = n / 2;
        int radius = n / 2;
        for (int r = 0; r < n; r++)
        {
            for (int c = 0; c < n; c++)
            {
                if ((c == radius + 2 && r == 5) || (c == radius + 2 && r == 6))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("-");
                }
                else if ((c == radius + 1 && r == 5) || (c == radius + 3 && r == 6))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("/");
                }
                else if ((c == radius + 3 && r == 5) || (c == radius + 1 && r == 6))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("\\");
                }
                else if ((int)Math.Abs(radius - c) * (int)Math.Abs(radius - c) +
                         (int)Math.Abs(radius - r) * (int)Math.Abs(radius - r) - 1 <=
                                       radius * radius)
                {
                    if (r >= radius + 1 && (c - radius >= r - radius) ||
                        (c > radius && r == radius + 1))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write(" ");
                    }
                    else
                    {
                        if (c % 2 != r % 2)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }

                        Console.Write("*");
                    }

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        };
        Console.WriteLine();
    }
    private static void InitDotsArray()
    {
        string fileName = @"..\..\Dots.txt";
        int row = -1;
        using (StreamReader streamReader = new StreamReader(fileName))
        {
            string textRow = streamReader.ReadLine();
            while (textRow != null)
            {
                row++;
                for (int i = 0; i < textRow.Length; i++)
                {
                    smallAndBigDots[row, i] = int.Parse(textRow[i].ToString());
                }
                textRow = streamReader.ReadLine();
            }
        }
    }
}
