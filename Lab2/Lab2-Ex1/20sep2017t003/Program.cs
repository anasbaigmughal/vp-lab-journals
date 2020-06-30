using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20sep2017t003
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your desired operation:\n");
            Console.Write("1. Create Account.\n");
            Console.Write("2. Display Account.\n");
            Console.Write("3. Update Account.\n");
            Console.Write("4. Delete Account.\n");

            string choice1 = Console.ReadLine();
            int option1 = int.Parse(choice1);

            if (option1 == 1)
            {

                Console.Write("Enter Account Type:\n");
                Console.Write("1.Current Account.\n");
                Console.Write("2.Saving Account.\n");

                string choice2 = Console.ReadLine();
                int option2 = int.Parse(choice2);

                if (option2 == 1)
                {
                    currentAccount CA = new currentAccount();

                    Console.Write("Enter Account Number:\n");
                    CA.accountNoProperty = Console.ReadLine();


                    Console.Write("Enter Account Title:\n");
                    CA.accountTitleProperty = Console.ReadLine();

                    Console.Write("Enter Account CNIC:\n");
                    CA.cnicProperty = Console.ReadLine();

                    Console.Write("Enter Account Contact Number:\n");
                    CA.contactNoProperty = Console.ReadLine();

                    Console.Write("Enter Account Balance:\n");
                    CA.balanceProperty = double.Parse(Console.ReadLine());

                    Console.Write("Enter Withdrawal Limit:\n");
                    CA.withdrawalLimitProperty = double.Parse(Console.ReadLine());
                }
                else
                {
                    savingAccount SA = new savingAccount();

                    Console.Write("Enter Account Number:\n");
                    SA.accountNoProperty = Console.ReadLine();


                    Console.Write("Enter Account Title:\n");
                    SA.accountTitleProperty = Console.ReadLine();

                    Console.Write("Enter Account CNIC:\n");
                    SA.cnicProperty = Console.ReadLine();

                    Console.Write("Enter Account Contact Number:\n");
                    SA.contactNoProperty = Console.ReadLine();

                    Console.Write("Enter Account Balance:\n");
                    SA.balanceProperty = double.Parse(Console.ReadLine());

                    Console.Write("Enter Withdrawal Limit:\n");
                    SA.profitPercentageProperty = float.Parse(Console.ReadLine());
                }
            }
        }
    }                                                                                                                    
}
