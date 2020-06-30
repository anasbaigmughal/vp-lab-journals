using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace smjConsoleApplication1
{
    class Program
    {
        static int add(int a, int b) //function to calculate sum
        {
            return (a + b);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter A:");
            string a = Console.ReadLine(); //reading input from keyboard
            Console.WriteLine("Enter B:");
            string b = Console.ReadLine(); //reading input from keyboard

            int A = int.Parse(a); //converting string to int
            int B = int.Parse(b); //converting string to int

            Console.WriteLine("\n===============================================================================");
            Console.WriteLine("                                   OUTPUT                                      ");
            Console.WriteLine("===============================================================================");

            Console.WriteLine("\nValue of A:");
            Console.WriteLine(A);
            Console.WriteLine("\nValue of B:");
            Console.WriteLine(B);
            Console.WriteLine("\nSum:");
            int sum = add(A, B); //function calling
            Console.WriteLine(sum);

            Console.ReadKey(); //to stop console from closing automatically  
        }
    }
}