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
  ╔══ ╔══╗ ══╦══
  ║   ║  ║   ║
  ╠══ ╠══╣   ║
  ║   ║  ║   ║
  ╚══ ║  ║   ║ 

    ╔═══ ║  ║ ╔══╗ ╔══╗ ╔══╗
    ║    ║  ║ ║  ║ ║  ║ ║  ║
    ╚══╗ ╠══╣ ╠══╣ ╠╦═╝ ╠══╝
       ║ ║  ║ ║  ║ ║╚═╗ ║  
    ═══╝ ║  ║ ║  ║ ║  ║ ║  

");
    }

}

