using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

namespace smjConsoleApplication1
{
    class Program
    {        
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("===============================================================================");
            Console.WriteLine("      B A H R I A - U N I V E R S I T Y - T E A - S H O P - S Y S T E M");
            Console.WriteLine("===============================================================================");

            menu m = new menu();
            m.consoleMenu();

            Console.ReadKey();
        }
    }
}
