using NAudio;
using NAudio.Wave;
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
    public static string monsters = "xНЕИД";

    public static string[] colors = { "Yellow", "Green", "White", "Magenta", "Cyan" };
    public static int[,] badGuysCoordinates = new int[5, 4];
    public static int[,] smallAndBigDots = new int[29, 30];

    public static bool endGame = true;
    public static bool endLevelOne = false;
    public static bool endLevelTwo = false;
    public static int points = 0;
    public static int lives = 3;
    public static int currentLevel = 1;
    public static int direction;

    public static int monsterOneCounter = 0;
    public static int monsterTwoCounter = 0;
    public static int monsterThreeCounter = 0;
    public static int monsterFourCounter = 0;

    private const int numberOfMovingObjects = 5;

    public static bool returnFromHighScores = true;
    public static bool returnFromInstructions = true;

    public static bool returnFromLevelOne = true;
    public static bool returnFromLevelTwo = true;

    public static List<string> highScores = new List<string>();
    public static StringBuilder user = new StringBuilder();

    public static IWavePlayer waveOutDevice;
    public static AudioFileReader audioFileReader = new AudioFileReader(@"..\..\Sounds\ThemeSong.mp3");

    public static void Main()
    {
        Console.Title = "EatSharp";

        Dimitar.SetConsoleWidthAndHeight();

        Console.OutputEncoding = Encoding.UTF8;

        if (returnFromHighScores && returnFromInstructions && returnFromLevelOne && returnFromLevelTwo)
        {
            DrawLogo(20);

            DimitarPiskov.PrintGameName();
            Console.ReadKey();
            Console.Clear();

            DimitarPiskov.Introduction();
            Console.ReadKey();
            Console.Clear();
        }

        // Menu

        Ivaylo.PrintingMenuGame();

        waveOutDevice = new WaveOut();

        ConsoleKeyInfo choice = Console.ReadKey();

        StringBuilder userNickname = new StringBuilder();

        if (choice.Key == ConsoleKey.D1)
        {
            Console.Clear();

            int currentColumn = 15;
            bool inputSuccess = true;
            var nickname = new List<ConsoleKeyInfo>();

            Dimitar.AskUserForNickname(ref currentColumn, ref inputSuccess, nickname);

            Console.ForegroundColor = ConsoleColor.White;

            Mariyan.DrawGameBoardLevelOne();
            Dimitar.StartCounter();

            InitDotsArray(1);

            waveOutDevice.Init(audioFileReader);
            waveOutDevice.Play();

            while (!endLevelOne)
            {
                Thread.Sleep(200);

                Ivaylo.MonsterNMovingLevelOne();
                Dimitar.MonsterIMovingLevelOne();
                Mariyan.MonsterDLevelOne();
                Antonina.monsterEMovingLevelOne();

                Georgi.RefreshScreen(badGuysCoordinates, Mariyan.wallsLevelOne);

                if (points == 1280) //1280
                {
                    Thread.Sleep(1500);

                    endLevelOne = true;
                    currentLevel = 2;
                    break;
                }

                else if (endGame == false)
                {
                    Dimitar.AskUserToRestartLevelOne(waveOutDevice, audioFileReader);
                }
            }

            waveOutDevice.Stop();

            Dimitar.LevelTwoMessage();
            Console.ReadKey();

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.White;

            Mariyan.DrawGameBoardLevelTwo();
            Dimitar.StartCounter();

            InitDotsArray(2);

            waveOutDevice.Init(audioFileReader);
            waveOutDevice.Play();

            monsterOneCounter = 0;
            monsterTwoCounter = 0;
            monsterThreeCounter = 0;
            monsterFourCounter = 0;

            while (!endLevelTwo)
            {
                Thread.Sleep(200);

                Ivaylo.MonsterNMovingLevelTwo();
                Mariyan.MonsterILevelTwo();
                Evgeni.MonsterDMovingLevelTwo();
                Ivaylo.MonsterEMovingLevelTwo();

                Georgi.RefreshScreen(badGuysCoordinates, Mariyan.wallsLevelTwo);

                if (points == 2600) //2600
                {
                    Thread.Sleep(1500);
                    endLevelTwo = true;
                    break;
                }

                else if (endGame == false)
                {
                    Dimitar.AskUserToRestartLevelTwo(waveOutDevice, audioFileReader);
                }

            }

            // End of level two
            Console.Clear();
            Mariyan.GameOutro();

            if (endGame == false)
            {
                try
                {

                    StreamWriter userScores = new StreamWriter(@"..\..\HighScores.txt");

                    using (userScores)
                    {
                        user.Append(points);
                        userScores.WriteLine(user);
                    }
                }
                catch (FileNotFoundException exMessage)
                {
                    Console.WriteLine("The file is not found!");
                    Console.WriteLine(exMessage.Message);
                }
            }
        }

        else if (choice.Key == ConsoleKey.D2)
        {
            UserChooseInstructionsMenu();
        }

        else if (choice.Key == ConsoleKey.D3)
        {
            UserChooseHighScoresMenu();

        }

        else if (choice.Key == ConsoleKey.D4)
        {
            Console.Clear();
            Environment.Exit(-1);
        }

        Console.CursorVisible = false;
    }

    private static void UserChooseHighScoresMenu()
    {
        Console.Clear();

        Console.SetCursorPosition(10, 2);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("HIGH SCORES");

        Console.SetCursorPosition(3, 5);
        Console.ForegroundColor = ConsoleColor.White;

        try
        {


            StreamReader userScoresRead = new StreamReader(@"..\..\HighScores.txt");

            Console.WriteLine(userScoresRead.ReadToEnd());
            userScoresRead.Close();
        }
        catch (FileLoadException exMessage)
        {
            Console.WriteLine("The file can't be load.");
            Console.WriteLine(exMessage.Message);
        }

        Console.SetCursorPosition(5, 30);
        Console.ForegroundColor = ConsoleColor.Green;
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

    private static void UserChooseInstructionsMenu()
    {
        Console.Clear();
        DimitarPiskov.Instructions();

        Console.SetCursorPosition(5, 30);
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Press ENTER to return");
        Console.SetCursorPosition(10, 31);
        Console.Write("to the MENU");

        if (Console.ReadKey().Key == ConsoleKey.Enter)
        {
            returnFromInstructions = false;
            Console.Clear();
            Main();
        }
        else
        {
            returnFromInstructions = false;
            Console.Clear();
            Main();
        }
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
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("-");
                }
                else if ((c == radius + 1 && r == 5) || (c == radius + 3 && r == 6))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("/");
                }
                else if ((c == radius + 3 && r == 5) || (c == radius + 1 && r == 6))
                {
                    Console.ForegroundColor = ConsoleColor.White;
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
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
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

    public static void InitDotsArray(int level)
    {
        string fileName = @"..\..\Dots" + level + ".txt";
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
        fileName = @"..\..\Level" + level + "Init.txt";
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
