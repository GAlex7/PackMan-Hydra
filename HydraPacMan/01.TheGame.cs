using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;
using System.Media;
using System.IO;

class PackManHydra
{
    public const int windowWidth = 31;
    public const int windowHeight = 33;
    public static string ourGuy = "X<>^v";
    public static string badGuys = "xQWMZ";

    public static string[] colors = { "Yellow", "Green", "White", "Magenta", "Cyan" };
    public static int[,] badGuysCoordinates = new int[5, 4];
    public static int[,] smallAndBigDots = new int[29, 30];

    public static bool endGame = true;
    public static bool endLevelOne = true;
    public static bool endLevelTwo = true;
    public static int points = 0;
    public static int lives = 3;
    public static int direction; // by GA

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
    static void Main()
    {
        // Заглавие на конзолата
        Console.Title = "PacMan";

        // Задаваме encoding за гадовете
        Console.OutputEncoding = Encoding.UTF8;

        // Задаваме размер на конзолата
        badGuysCoordinates[0, 0] = 15; //Console.WindowHeight = windowHeight;
        badGuysCoordinates[0, 1] = 21; //Console.WindowWidth = windowWidth;
        //Console.BufferHeight = Console.WindowHeight;
        //Console.BufferWidth = Console.WindowWidth;

        // Фонова музика
        //SoundPlayer player = new SoundPlayer();

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

        //player.SoundLocation = gameSounds + @"\sounds\ThemeSong.wav";
        //player.Load();
        //player.Play();

        while (true)
        {
            Thread.Sleep(150);

            // Викане на гадовете от класове

            // Викане на нашето човече

            // Обновяване на екрана
            
            Georgi.RefreshScreen(badGuysCoordinates);

            // 

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

}
