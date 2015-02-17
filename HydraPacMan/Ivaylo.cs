using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Ivaylo
{
    public static void PrintingMenuGame()
    {
        Console.SetCursorPosition(5, 11);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("********************\n");
        Console.SetCursorPosition(5, 12);
        Console.Write("*       ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("MENU");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("       *\n");
        Console.SetCursorPosition(5, 13);
        Console.Write("*                  *\n");
        Console.SetCursorPosition(5, 14);
        Console.Write("*  ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("1. NEW   GAME");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("   *\n");
        Console.SetCursorPosition(5, 15);
        Console.Write("*                  *\n");
        Console.SetCursorPosition(5, 16);
        Console.Write("*  ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("2. LOAD  GAME");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("   *\n");
        Console.SetCursorPosition(5, 17);
        Console.Write("*                  *\n");
        Console.SetCursorPosition(5, 18);
        Console.Write("*  ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("3. SCORE GAME");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("   *\n");
        Console.SetCursorPosition(5, 19);
        Console.Write("*                  *\n");
        Console.SetCursorPosition(5, 20);
        Console.Write("*  ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("4. EXIT  GAME");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("   *\n");
        Console.SetCursorPosition(5, 21);
        Console.Write("*                  *\n");
        Console.SetCursorPosition(5, 22);
        Console.Write("********************");
        Console.WriteLine();
        Console.CursorVisible = false;
        int menuInput = int.Parse(Console.ReadLine());
    }
}

