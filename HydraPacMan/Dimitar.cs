using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
class Dimitar
{
    public static int[,] monsterICoordinatesLevelOne = new int[, ] 
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
    public static void MonsterIMovingLevelOne()
    {
        PackManHydra.badGuysCoordinates[3, 0] = PackManHydra.badGuysCoordinates[3, 2];
        PackManHydra.badGuysCoordinates[3, 1] = PackManHydra.badGuysCoordinates[3, 3];

        PackManHydra.badGuysCoordinates[3, 2] = monsterICoordinatesLevelOne[PackManHydra.monsterThreeCounter, 0];
        PackManHydra.badGuysCoordinates[3, 3] = monsterICoordinatesLevelOne[PackManHydra.monsterThreeCounter, 1];

        if (PackManHydra.monsterThreeCounter == monsterICoordinatesLevelOne.GetLength(0) - 1)
        {
            PackManHydra.monsterThreeCounter = 8;
        }

        else
        {
            PackManHydra.monsterThreeCounter++;
        }

        PackManHydra.badGuysCoordinates[3, 2] = monsterICoordinatesLevelOne[PackManHydra.monsterThreeCounter, 0];
        PackManHydra.badGuysCoordinates[3, 3] = monsterICoordinatesLevelOne[PackManHydra.monsterThreeCounter, 1];

    }

    public static void SetConsoleWidthAndHeight()
    {
        Console.WindowHeight = PackManHydra.windowHeight;
        Console.WindowWidth = PackManHydra.windowWidth;

        Console.BufferHeight = Console.WindowHeight;
        Console.BufferWidth = Console.WindowWidth;
    }
    
    public static void StartCounter()
    {
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
    }

    public static void LevelTwoMessage()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(8, 11);
        Console.Write("Congratulations!");
        Console.SetCursorPosition(1, 13);
        Console.Write("You passed C# 1 successfully");
        Console.SetCursorPosition(4, 14);
        Console.Write("but now the lectors are");
        Console.SetCursorPosition(7, 15);
        Console.Write("angrier than ever!");
        Console.SetCursorPosition(4, 17);
        Console.Write("They will do everything");
        Console.SetCursorPosition(10, 18);
        Console.Write("to stop you!");
        Console.SetCursorPosition(11, 20);
        Console.Write("Watch out...");


    }

    public static void AskUserForNickname(ref int currentColumn, ref bool inputSuccess, List<ConsoleKeyInfo> nickname)
    {
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
                    PackManHydra.user.Append(userScoresRead.ReadToEnd());
                    PackManHydra.user.Append("\n");
                }


                StreamWriter userScores = new StreamWriter(@"..\..\HighScores.txt");

                using (userScores)
                {
                    PackManHydra.user.Append("         ");

                    for (int i = 0; i < nickname.Count; i++)
                    {
                        PackManHydra.user.Append(nickname[i].KeyChar);
                    }

                    PackManHydra.user.Append(" - ");
                    userScores.Write(PackManHydra.user);
                }
                userScores.Close();

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
    }

    public static void AskUserToRestartLevelOne(IWavePlayer waveOutDevice, AudioFileReader audioFileReader)
    {
        waveOutDevice.Stop();
        Console.Clear();

        Console.SetCursorPosition(5, 15);
        Console.Write("Do you want to RESTART?");
        Console.SetCursorPosition(14, 16);
        Console.WriteLine("Y/N");

        ConsoleKeyInfo check = Console.ReadKey();

        Console.Clear();

        if (check.Key.ToString().ToLower() == "y")
        {
            Console.Clear();

            PackManHydra.monsterOneCounter = 0;
            PackManHydra.monsterTwoCounter = 0;
            PackManHydra.monsterThreeCounter = 0;
            PackManHydra.monsterFourCounter = 0;

            PackManHydra.points = 0;
            PackManHydra.lives = 3;
            PackManHydra.currentLevel = 1;

            Console.ForegroundColor = ConsoleColor.White;

            Mariyan.DrawGameBoardLevelOne();
            Dimitar.StartCounter();

            PackManHydra.InitDotsArray(1);

            waveOutDevice.Init(audioFileReader);
            waveOutDevice.Play();

            PackManHydra.endGame = true;

            Georgi.RefreshScreen(PackManHydra.badGuysCoordinates, Mariyan.wallsLevelOne);
        }
        else if (check.Key.ToString().ToLower() == "n")
        {
            Console.Clear();

            PackManHydra.monsterOneCounter = 0;
            PackManHydra.monsterTwoCounter = 0;
            PackManHydra.monsterThreeCounter = 0;
            PackManHydra.monsterFourCounter = 0;

            PackManHydra.points = 0;
            PackManHydra.lives = 3;
            PackManHydra.currentLevel = 1;

            PackManHydra.returnFromLevelOne = false;
            PackManHydra.endGame = true;

            PackManHydra.Main();
        }
    }

    public static void AskUserToRestartLevelTwo(IWavePlayer waveOutDevice, AudioFileReader audioFileReader)
    {
        waveOutDevice.Stop();

        Console.Clear();

        Console.SetCursorPosition(5, 15);
        Console.Write("Do you want to RESTART");
        Console.SetCursorPosition(13, 16);
        Console.WriteLine("Y/N");

        var check = Console.ReadKey();

        Console.Clear();

        if (check.Key.ToString().ToLower() == "y")
        {
            Console.Clear();

            PackManHydra.monsterOneCounter = 0;
            PackManHydra.monsterTwoCounter = 0;
            PackManHydra.monsterThreeCounter = 0;
            PackManHydra.monsterFourCounter = 0;

            PackManHydra.points = 0;
            PackManHydra.lives = 3;
            PackManHydra.currentLevel = 2;

            Console.ForegroundColor = ConsoleColor.White;

            Mariyan.DrawGameBoardLevelTwo();
            Dimitar.StartCounter();

            PackManHydra.InitDotsArray(1);

            waveOutDevice.Init(audioFileReader);
            waveOutDevice.Play();

            PackManHydra.endGame = true;

            Georgi.RefreshScreen(PackManHydra.badGuysCoordinates, Mariyan.wallsLevelTwo);
        }
        else if (check.Key.ToString().ToLower() == "n")
        {
            Console.Clear();

            PackManHydra.monsterOneCounter = 0;
            PackManHydra.monsterTwoCounter = 0;
            PackManHydra.monsterThreeCounter = 0;
            PackManHydra.monsterFourCounter = 0;

            PackManHydra.points = 0;
            PackManHydra.lives = 3;
            PackManHydra.currentLevel = 1;

            PackManHydra.endGame = true;

            PackManHydra.endLevelOne = false;

            PackManHydra.returnFromLevelTwo = false;
            Console.Clear();

            PackManHydra.Main();
        }
    }
}

