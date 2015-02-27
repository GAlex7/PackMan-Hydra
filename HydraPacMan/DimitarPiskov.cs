using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DimitarPiskov
{
    public static void PrintGameName()
    {
        Console.SetCursorPosition(4, 20);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(@"  
  ╔═╣ ╔══╗ ╠═╦═╣
  ║   ║  ║   ║
  ╠═╣ ╠══╣   ║
  ║   ║  ║   ║
  ╚═╣ ╩  ╩   ╩ 

    ╔══╣ ╦  ╦ ╔══╗ ╔══╗ ╔══╗
    ║    ║  ║ ║  ║ ║  ║ ║  ║
    ╚══╗ ╠══╣ ╠══╣ ╠╦═╝ ╠══╝
       ║ ║  ║ ║  ║ ║╚═╗ ║
    ╠══╝ ╩  ╩ ╩  ╩ ╩  ╩ ╩");
    }

    public static void Introduction()
    {
        for (int i = 0; i < 31; i++)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(i, 8);
            Console.Write("*");
            Console.SetCursorPosition(i, 24);
            Console.Write("*");
        }
        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(7, 9);
        Console.Write("Congratulations!");
        Console.SetCursorPosition(1, 10);
        Console.Write(" You just entered the castle");
        Console.SetCursorPosition(1, 11);
        Console.Write("   of Telerik. As a future  ");
        Console.SetCursorPosition(1, 12);
        Console.Write(" .NET Ninja you must collect");
        Console.SetCursorPosition(1, 13);
        Console.Write("     all \"#\" symbols.     ");
        Console.SetCursorPosition(1, 14);
        Console.Write("The dark forces of the castle");
        Console.SetCursorPosition(1, 15);
        Console.Write("  (the lectors - Д, Е, И, Н)");
        Console.SetCursorPosition(1, 16);
        Console.Write("will do anything to stop you.");
        Console.SetCursorPosition(1, 17);
        Console.Write("Once they catch you - you're");
        Console.SetCursorPosition(1, 18);
        Console.Write("dead so try to stay away from");
        Console.SetCursorPosition(1, 19);
        Console.Write("them! After you collect(eat)");
        Console.SetCursorPosition(1, 20);
        Console.Write("all the \"#\" symbols you go");
        Console.SetCursorPosition(1, 21);
        Console.Write(" to the next level. Pass all");
        Console.SetCursorPosition(1, 22);
        Console.Write("the levels and become a .NET");
        Console.SetCursorPosition(1, 23);
        Console.Write("      Ninja! Good luck!     ");
        Console.CursorVisible = false;
        for (int i = 9; i < 24; i++)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(0, i);
            Console.Write("*");
            Console.SetCursorPosition(30, i);
            Console.Write("*");
        }
    }
    public static void Instructions()
    {
        int a = 1;
        for (int i = a; i < a + 16; i++)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(0, i);
            Console.Write("#");
            Console.SetCursorPosition(30, i);
            Console.Write("#");
        }
    }
}