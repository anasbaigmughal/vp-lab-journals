using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

namespace smjConsoleApplication1
{
    class menu
    {
        public void consoleMenu()
        {
            sale s = new sale();
            Console.WriteLine("Enter Desired operation:");
            Console.WriteLine("1. New Sale.");
            Console.WriteLine("2. Print Invoices.");

            int option1 = int.Parse(Console.ReadLine());

            if (option1 == 1)
            {
                s.newSale();
            }
            else if (option1 == 2)
            {
                ArrayList list = s.getAllSales();
                for (int i = 0; i < list.Count; i++)
                {
                    sale obj = list[i] as sale;
                    obj.printInvoice();
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
