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

    public static string[] colors = { "Yellow", "Green", "White", "DarkMagenta", "Blue" };
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

    private const int numberOfMovingObjects = 5;

    private static bool returnFromHighScores = true;
    //private static string gameSounds = Directory.GetCurrentDirectory();

    //Антонина 
    public static int[,] availablePositionsGuyQ = new int[,]
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

    //Ивайло
    
    //Мариян
    public static int[,] monsterW = new int[,] 
        {
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

    private static string gameSounds = Directory.GetCurrentDirectory();

    static void Main()
    {
        // Заглавие на конзолата
        Console.Title = "EatSharp";

        // Задаваме размер на конзолата
        Dimitar.SetConsoleWidthAndHeight();

        // Encoding
        Console.OutputEncoding = Encoding.UTF8;

        // Бонус точки
        InitDotsArray();

        // Фонова музика
        // SoundPlayer player = new SoundPlayer();
        // SoundPlayer player = new SoundPlayer();

        // Принтиране на логото и заглавието, изчакване за натискане на клавиш преди преминаване напред

        if (returnFromHighScores)
        {
            DrawLogo(20);

            DimitarPiskov.PrintGameName();
            Console.ReadKey();
            Console.Clear();

            DimitarPiskov.Introduction();
            Console.ReadKey();
            Console.Clear();
        }

        // Меню: 1.New Game, 2.Instruction, 3.High Score, 4.Exit game

        Ivaylo.PrintingMenuGame();

        // Начална позиция на нашето човече
        //badGuysCoordinates[0, 0] = 15;
        //badGuysCoordinates[0, 1] = 21;

        ConsoleKeyInfo choice = Console.ReadKey();

        StringBuilder userNickname = new StringBuilder();

        if (choice.Key == ConsoleKey.D1)
        {
            Console.Clear();

            int currentColumn = 15;
            bool inputSuccess = true;
            var nickname = new List<ConsoleKeyInfo>();
            StreamWriter userScores = new StreamWriter(@"..\..\HighScores.txt");

            while (inputSuccess)
            {
                Console.SetCursorPosition(5, 15);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Please enter nickname:");
                Console.SetCursorPosition(currentColumn, 17);

                for (int i = 0; i < nickname.Count; i++)
                {
                    Console.Write(nickname[i].KeyChar);
                }

                ConsoleKeyInfo inputLetter = Console.ReadKey();
                if (inputLetter.Key == ConsoleKey.Enter && nickname.Count >= 1)
                {
                    using (userScores)
                    {
                        for (int i = 0; i < nickname.Count; i++)
                        {
                            userScores.Write(nickname[i].KeyChar);
                        }
                        userScores.Write(" - ");
                        userScores.Flush();
                    }
                    inputSuccess = false;
                }
                else if (inputLetter.Key == ConsoleKey.Enter && nickname.Count == 0)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(2, 17);
                    Console.WriteLine("Enter at least 1 character!");
                    continue;
                }

                if (inputLetter.Key != ConsoleKey.Backspace)
                {
                    nickname.Add(inputLetter);
                    if (nickname.Count % 2 == 0)
                    {
                        currentColumn--;
                    }
                }
                else if (inputLetter.Key == ConsoleKey.Backspace)
                {
                    if (nickname.Count == 0)
                    {
                        continue;
                    }

                    nickname.RemoveAt(nickname.Count - 1);
                    if (nickname.Count % 2 == 0)
                    {
                        currentColumn++;
                    }
                }

                Console.Clear();
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Marian.DrawGameBoardLevelOne();
            Dimitar.StartCounter();

            //player.SoundLocation = gameSounds + @"\sounds\ThemeSong.wav";
            //player.Load();
            //player.Play();

            while (true)
            {
                // Забавяне на конзолата
                Thread.Sleep(200);

                // Викане на нашето човече
                Ivaylo.MonsterNMoving();
                Dimitar.MonsterIMoving();
                Marian.MonsterW();
                Antonina.BadGuyQ();

                // Обновяване на екрана
                Georgi.RefreshScreen(badGuysCoordinates);

                // Проверка за сблъсък и проверка за изяден бонус
            }
        }
        else if (choice.Key == ConsoleKey.D2)
        {
            Console.Clear();
            DimitarPiskov.Instructions();
            Console.ReadKey(true);
        }
        else if (choice.Key == ConsoleKey.D3)
        {
            Console.Clear();
            Console.SetCursorPosition(11, 2);
            Console.Write("HIGH SCORES");
            Console.SetCursorPosition(3, 5);
            // Извикване на файла, който държи High scores
            StreamReader userScoresRead = new StreamReader(@"..\..\HighScores.txt");
            Console.WriteLine(userScoresRead.ReadToEnd());
            Console.SetCursorPosition(5, 30);
            Console.Write("Press enter to return");
            Console.SetCursorPosition(10, 31);
            Console.Write("to the MENU");

            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                returnFromHighScores = false;
                Console.Clear();
                Main();
            }
            else
            {
                returnFromHighScores = false;
                Console.Clear();
                Main();
            }

        }
        else if (choice.Key == ConsoleKey.D4)
        {
            Console.Clear();
            Environment.Exit(-1);
        }
        Console.CursorVisible = false;

    }

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
        fileName = @"..\..\LevelOneInit.txt";
        row = -1;
        using (StreamReader streamReader = new StreamReader(fileName))
        {
            string textRow = streamReader.ReadLine();
            while (textRow != null)
            {
                row++;
                string[] xy = textRow.Split(' ');

                badGuysCoordinates[row, 0] = int.Parse(xy[0]);
                badGuysCoordinates[row, 1] = int.Parse(xy[1]);
                badGuysCoordinates[row, 2] = int.Parse(xy[2]);
                badGuysCoordinates[row, 3] = int.Parse(xy[3]);

                textRow = streamReader.ReadLine();
            }
        }
    }

}
