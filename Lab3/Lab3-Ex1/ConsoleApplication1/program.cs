using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

namespace ConsoleApplication1
{
    class program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("===============================================================================");
            Console.WriteLine("   B A H R I A - U N I V E R S I T Y - V I R T U A L - B A N K - S Y S T E M");
            Console.WriteLine("===============================================================================");
            consoleMenu c = new consoleMenu();
            c.startMenu();
            Console.ReadLine();
        }
    }
}