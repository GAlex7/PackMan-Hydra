﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Media;
using System.Text; using NAudio;
using System.Threading; using NAudio.Wave;

class PackManHydra
{
    public const int windowWidth = 40;
    public const int windowHeight = 40;
    public static string ourGuy = "X<>^vx--::";
    public static string badGuys = "xНЕИД";

    public static string[] colors = { "Yellow", "Green", "White", "DarkMagenta", "Cyan" };
    public static int[,] badGuysCoordinates = new int[5, 4];
    public static int[,] smallAndBigDots = new int[29, 30];

    public static bool endGame = true;
    public static bool endLevelOne = false;
    public static bool endLevelTwo = false;
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
    private static bool returnFromInstructions = true;
    private static string gameSounds = Directory.GetCurrentDirectory();
    public static List<string> highScores = new List<string>();
    public static StringBuilder user = new StringBuilder();


    static void Main()
    {
        // Заглавие на конзолата
        Console.Title = "EatSharp";

        // Задаваме размер на конзолата
        Dimitar.SetConsoleWidthAndHeight();

        // Encoding
        Console.OutputEncoding = Encoding.UTF8;

        // Бонус точки
        //InitDotsArray();

        // Фонова музика
        //SoundPlayer player = new SoundPlayer();

        // Принтиране на логото и заглавието, изчакване за натискане на клавиш преди преминаване напред
        //try
        //{
            if (returnFromHighScores && returnFromInstructions)
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

            IWavePlayer waveOutDevice;
            AudioFileReader audioFileReader = new AudioFileReader(@"..\..\Sounds\ThemeSong.mp3");  //GAlex
            waveOutDevice = new WaveOut();

            ConsoleKeyInfo choice = Console.ReadKey();

            StringBuilder userNickname = new StringBuilder();

            if (choice.Key == ConsoleKey.D1)
            {
                Console.Clear();

                int currentColumn = 15;
                bool inputSuccess = true;
                var nickname = new List<ConsoleKeyInfo>();

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
                    if (inputLetter.Key == ConsoleKey.Enter && nickname.Count >= 3)
                    {
                        StreamReader userScoresRead = new StreamReader(@"..\..\HighScores.txt");
                        using (userScoresRead)
                        {
                            user.Append(userScoresRead.ReadToEnd());
                            user.Append("\n");
                        }
                        StreamWriter userScores = new StreamWriter(@"..\..\HighScores.txt");
                        using (userScores)
                        {
                            user.Append("         ");
                            for (int i = 0; i < nickname.Count; i++)
                            {
                                user.Append(nickname[i].KeyChar);
                            }
                            user.Append(" - ");
                            userScores.Write(user);
                        }
                        inputSuccess = false;
                    }
                    else if (inputLetter.Key == ConsoleKey.Enter && nickname.Count < 3)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(2, 19);
                        Console.WriteLine("Enter at least 3 characters!");
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
                Mariyan.DrawGameBoardLevelOne();
                Dimitar.StartCounter();
                InitDotsArray(1);
                waveOutDevice.Init(audioFileReader);
                waveOutDevice.Play();

                while (endGame)
                {

                    Thread.Sleep(200);
                    // Викане на нашето човече
                    Ivaylo.MonsterNMovingLevelOne();
                    Dimitar.MonsterIMovingLevelOne();
                    Mariyan.MonsterDLevelOne();
                    Antonina.monsterEMovingLevelOne();

                    // Обновяване на екрана
                    Georgi.RefreshScreen(badGuysCoordinates,Mariyan.wallsLevelOne);

                    // Проверка за сблъсък и проверка за изяден бонус
                    if (points == 1280) // 1280 - end
                    {
                        Thread.Sleep(1500);
                        endLevelOne = true;
                        endLevelTwo = true;
                        break;
                        

                    }
                }

                waveOutDevice.Stop();

                Dimitar.LevelTwoMessage();
                Console.ReadKey();

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Mariyan.DrawGameBoardLevelTwo();
                Dimitar.StartCounter();
                InitDotsArray(2);
                waveOutDevice.Init(audioFileReader);
                waveOutDevice.Play();

                GadOneCounter = 0;
                GadTwoCounter = 0;
                GadThreeCounter = 0;
                GadFourCounter = 0;

                while (endLevelTwo)
                {
                    Thread.Sleep(200);

                    Ivaylo.MonsterNMovingLevelTwo();
                    Mariyan.MonsterILevelTwo();
                    Evgeni.MonsterDMovingLevelTwo();
                    Ivaylo.MonsterEMovingLevelTwo();

                    Georgi.RefreshScreen(badGuysCoordinates, Mariyan.wallsLevelTwo);
                    
                    if (points == 1340) //1335
                    {
                        Console.Clear();
                        break;
                    }

                }

                Console.SetCursorPosition(5, 15);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Please enter nickname:");

                if (endGame == false)
                {
                    StreamWriter userScores = new StreamWriter(@"..\..\HighScores.txt");
                    using (userScores)
                    {
                        user.Append(points);
                        userScores.WriteLine(user);
                    }
                }
            }
            else if (choice.Key == ConsoleKey.D2)
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

            else if (choice.Key == ConsoleKey.D3)
            {
                StreamReader userScoresRead = new StreamReader(@"..\..\HighScores.txt");
                Console.Clear();
                Console.SetCursorPosition(10, 2);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("HIGH SCORES");

                // Извикване на файла, който държи High scores
                Console.SetCursorPosition(3, 5);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(userScoresRead.ReadToEnd());
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
            else if (choice.Key == ConsoleKey.D4)
            {
                Console.Clear();
                Environment.Exit(-1);
            }
            Console.CursorVisible = false;


        //}
        //catch (Exception ex)
        //{
        //    t
        //    Console.Clear();
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    Console.SetCursorPosition(8, 15);
        //    Console.WriteLine("Unexpected error");
        //    Console.SetCursorPosition(8, 16);
        //    Console.WriteLine("durring loading\n");
        //    Console.ReadKey();
        //    Environment.Exit(-1);
        //}
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
    private static void InitDotsArray(int level)
    {
        string fileName = @"..\..\Dots"+level+".txt";
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
        fileName = @"..\..\Level"+level+"Init.txt";
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
