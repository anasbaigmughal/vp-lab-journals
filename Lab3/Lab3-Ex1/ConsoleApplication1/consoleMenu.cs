using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

namespace ConsoleApplication1
{
    class consoleMenu
    {
        accountManager manager = new accountManager();

        public void startMenu()
        {
            printOptions();
            int num = int.Parse(Console.ReadLine());
            if( num == 1 )
            {
                accountCreation();
            }
            if( num == 2 )
            {
                searchAccount();
            }
            if (num == 3)
            {
                updateAccount();
            }
            if (num == 4)
            {
                deleteAccount();
            }
            if (num == 5)
            {
                displayAccount();
            }
            if (num == 6)
            {
                transaction();
            }
        }

        public void printOptions()
        {
            Console.WriteLine("Enter your desired operation:");
            Console.WriteLine("1. Create New Account.");
            Console.WriteLine("2. Search Account by Account Number.");
            Console.WriteLine("3. Update Account by Account Number.");
            Console.WriteLine("4. Delete Account by Account Number.");
            Console.WriteLine("5. Display Account by Account Number.");
            Console.WriteLine("6. Deposit / Withdraw by Account Number.");
        }

        public void accountCreation()
        {
            int num;
            do
            {
                Console.Write("\nEnter Account Number:\n");
                string An = Console.ReadLine();

                Console.Write("\nEnter Account Title:\n");
                string At = Console.ReadLine();

                Console.Write("\nEnter CNIC:\n");
                string cnic = Console.ReadLine();

                Console.Write("\nEnter Contact Number:\n");
                string cn = Console.ReadLine();

                Console.Write("\nEnter Account Balance:\n");
                double bal = double.Parse(Console.ReadLine());

                Console.Write("\nChoose Account Type:\n");
                Console.Write("1.Saving Account.    2.Current Account.\n");
                int option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    Console.WriteLine("\nEnter Profit Percentage:");
                    float pp = float.Parse(Console.ReadLine());

                    savingAccount savingAcc = new savingAccount(An, At, cnic, cn, bal, pp);
                    manager.createNewSavingAccount(savingAcc);
                }
                if (option == 2)
                {
                    Console.WriteLine("\nEnter Withdrawal Limit:");
                    double wl = double.Parse(Console.ReadLine());

                    currentAccount currentAcc = new currentAccount(An, At, cnic, cn, bal, wl);
                    manager.createNewCurrentAccount(currentAcc);
                }
                Console.WriteLine("\nPress 1 to continue creation of Accounts.");
                num = int.Parse(Console.ReadLine());
            }
            while (num == 1);
            manager.writeAllinFile();
        }

        public void searchAccount()
        {
            Console.Write("\nChoose Account Type:\n");
            Console.Write("1.Current Account.    2.Saving Account.\n");
            int num = int.Parse(Console.ReadLine());

            if ( num == 1)
            {
                Console.WriteLine("\nEnter Account Number:");
                string accnum = Console.ReadLine();
                manager.searchCurrentAccount(accnum);
            }
            else if( num  == 2)
            {
                Console.WriteLine("\nEnter Account Number:");
                string accnum = Console.ReadLine();
                manager.searchSavingAccount(accnum);
            }
            else
            {
                Console.WriteLine("Invalid Input\n");
            }
        }

        public void updateAccount()
        {
            Console.Write("\nChoose Account Type:\n");
            Console.Write("1.Current Account.   2.Saving Account.\n");
            int num = int.Parse(Console.ReadLine());

            if (num == 1)
            {
                Console.WriteLine("\nEnter Account Number:");
                string accnum = Console.ReadLine();

                accountFile obj = new accountFile();
                List<currentAccount> accounts = obj.readAllCurrentAccount(); //simple list: saves same type of objects
                int totalAccounts = accounts.Count; //built-in count list function
                bool found = false;

                for (int i = 0; i < totalAccounts; i++)
                {
                    if (accounts[i].accountNoProperty == accnum)
                    {
                        found = true;
                        Console.WriteLine("\nAccount Found.\n");

                        Console.Write("\nEnter New Account Number:\n");
                        accounts[i].accountNoProperty = Console.ReadLine();

                        Console.Write("\nEnter New Account Title:\n");
                        accounts[i].accountTitleProperty = Console.ReadLine();

                        Console.Write("\nEnter New CNIC:\n");
                        accounts[i].cnicProperty = Console.ReadLine();

                        Console.Write("\nEnter New Contact Number:\n");
                        accounts[i].contactNoProperty = Console.ReadLine();

                        Console.Write("\nEnter New Account Balance:\n");
                        accounts[i].balanceProperty = double.Parse(Console.ReadLine());

                        Console.WriteLine("\nEnter New Withdrawal Limit:");
                        accounts[i].withdrawalLimitProperty = double.Parse(Console.ReadLine());
                    }
                }
                
                StreamWriter writeCurrent = new StreamWriter("CurrentAccount.txt"); //write to file object
                //int totalAccount = accounts.Count;
                for (int j = 0; j < totalAccounts; j++)
                {
                    currentAccount account = accounts[j];
                    writeCurrent.WriteLine(account.accountNoProperty);
                    writeCurrent.WriteLine(account.accountTitleProperty);
                    writeCurrent.WriteLine(account.balanceProperty);
                    writeCurrent.WriteLine(account.cnicProperty);
                    writeCurrent.WriteLine(account.contactNoProperty);
                    writeCurrent.WriteLine(account.withdrawalLimitProperty);
                }
                writeCurrent.Close();
                return;
            }

            else if (num == 2)
            {
                Console.WriteLine("\nEnter Account Number:");
                string accnum = Console.ReadLine();

                accountFile obj = new accountFile();
                ArrayList accounts = obj.readAllSavingAccount(); //array list: saves diffeent types of objects
                //List<currentAccount> accounts = obj.readAllCurrentAccount(); //simple list: saves same type of objects
                int totalAccounts = accounts.Count; //built-in count list function
                bool found = false;

                for (int i = 0; i < totalAccounts; i++)
                {
                    if ((accounts[i] as savingAccount).accountNoProperty == accnum)
                    {
                        found = true;
                        Console.WriteLine("\nAccount Found.\n");

                        Console.Write("\nEnter New Account Number:\n");
                        (accounts[i] as savingAccount).accountNoProperty = Console.ReadLine();

                        Console.Write("\nEnter New Account Title:\n");
                        (accounts[i] as savingAccount).accountTitleProperty = Console.ReadLine();

                        Console.Write("\nEnter New CNIC:\n");
                        (accounts[i] as savingAccount).cnicProperty = Console.ReadLine();

                        Console.Write("\nEnter New Contact Number:\n");
                        (accounts[i] as savingAccount).contactNoProperty = Console.ReadLine();

                        Console.Write("\nEnter New Account Balance:\n");
                        (accounts[i] as savingAccount).balanceProperty = double.Parse(Console.ReadLine());

                        Console.WriteLine("\nEnter New Profit Percentage:");
                        (accounts[i] as savingAccount).profitPercentageProperty = float.Parse(Console.ReadLine());
                    }
                }

                StreamWriter writeSaving = new StreamWriter("SavingAccount.txt"); //write to file object
                //int totalAccount = accounts.Count;
                for (int j = 0; j < totalAccounts; j++)
                {
                    savingAccount account = accounts[j] as savingAccount;
                    writeSaving.WriteLine(account.accountNoProperty);
                    writeSaving.WriteLine(account.accountTitleProperty);
                    writeSaving.WriteLine(account.balanceProperty);
                    writeSaving.WriteLine(account.cnicProperty);
                    writeSaving.WriteLine(account.contactNoProperty);
                    writeSaving.WriteLine(account.profitPercentageProperty);
                }
                writeSaving.Close();
                return;
            }
            else
            {
                Console.WriteLine("Invalid Input\n");
            }
        }

        public void deleteAccount()
        {
            Console.Write("\nChoose Account Type:\n");
            Console.Write("1.Current Account.   2.Saving Account.\n");
            int num = int.Parse(Console.ReadLine());

            if (num == 1)
            {
                Console.WriteLine("\nEnter Account Number:");
                string accnum = Console.ReadLine();
                accountFile obj = new accountFile();
                List<currentAccount> accounts = obj.readAllCurrentAccount(); //simple list: saves same type of objects
                int totalAccounts = accounts.Count; //built-in count list function
                bool found = false;

                for (int i = 0; i < totalAccounts; i++)
                {
                    if (accounts[i].accountNoProperty == accnum)
                    {
                        found = true;
                        Console.WriteLine("\nAccount Found.\n");

                        accounts.Remove(accounts[i]); //deletes that object with i index
                        totalAccounts--;
                    }
                }

                StreamWriter writeCurrent = new StreamWriter("CurrentAccount.txt"); //write to file object
                
                for (int j = 0; j < totalAccounts; j++)
                {
                    currentAccount account = accounts[j];
                    writeCurrent.WriteLine(account.accountNoProperty);
                    writeCurrent.WriteLine(account.accountTitleProperty);
                    writeCurrent.WriteLine(account.balanceProperty);
                    writeCurrent.WriteLine(account.cnicProperty);
                    writeCurrent.WriteLine(account.contactNoProperty);
                    writeCurrent.WriteLine(account.withdrawalLimitProperty);
                }
                writeCurrent.Close();
                return;
            }

            else if (num == 2)
            {
                Console.WriteLine("\nEnter Account Number:");
                string accnum = Console.ReadLine();
                accountFile obj = new accountFile();
                ArrayList accounts = obj.readAllSavingAccount(); //array list: saves diffeent types of objects
                int totalAccounts = accounts.Count; //built-in count list function
                bool found = false;

                for (int i = 0; i < totalAccounts; i++)
                {
                    if ((accounts[i] as savingAccount).accountNoProperty == accnum)
                    {
                        found = true;
                        Console.WriteLine("\nAccount Found.\n");

                        accounts.Remove(accounts[i]); //deletes that object with i index
                        totalAccounts--;
                    }
                }

                StreamWriter writeSaving = new StreamWriter("SavingAccount.txt"); //write to file object
                
                for (int j = 0; j < totalAccounts; j++)
                {
                    savingAccount account = accounts[j] as savingAccount;
                    writeSaving.WriteLine(account.accountNoProperty);
                    writeSaving.WriteLine(account.accountTitleProperty);
                    writeSaving.WriteLine(account.balanceProperty);
                    writeSaving.WriteLine(account.cnicProperty);
                    writeSaving.WriteLine(account.contactNoProperty);
                    writeSaving.WriteLine(account.profitPercentageProperty);
                }
                writeSaving.Close();
                return;
            }
            else
            {
                Console.WriteLine("Invalid Input\n");
            }
        }


        public void displayAccount()
        {
            Console.Write("\nChoose Account Type:\n");
            Console.Write("1.Current Account.   2.Saving Account.\n");
            int num = int.Parse(Console.ReadLine());

            if (num == 1)
            {
                Console.WriteLine("\nEnter Account Number:");
                string accnum = Console.ReadLine();

                accountFile obj = new accountFile();
                List<currentAccount> accounts = obj.readAllCurrentAccount(); //simple list: saves same type of objects
                int totalAccounts = accounts.Count; //built-in count list function
                bool found = false;

                for (int i = 0; i < totalAccounts; i++)
                {
                    if (accounts[i].accountNoProperty == accnum)
                    {
                        found = true;
                        Console.WriteLine("\nAccount Found.\n");

                        Console.Write("\nAccount Number:    ");
                        Console.Write(accounts[i].accountNoProperty);

                        Console.Write("\nAccount Title: ");
                        Console.Write(accounts[i].accountTitleProperty);

                        Console.Write("\nCNIC:  ");
                        Console.Write(accounts[i].cnicProperty);

                        Console.Write("\nContact Number:    ");
                        Console.Write(accounts[i].contactNoProperty);

                        Console.Write("\nAccount Balance:   ");
                        Console.Write(accounts[i].balanceProperty);

                        Console.WriteLine("\nWithdrawal Limit:  ");
                        Console.Write(accounts[i].withdrawalLimitProperty);
                    }
                }
            }

            else if (num == 2)
            {
                Console.WriteLine("\nEnter Account Number:");
                string accnum = Console.ReadLine();

                accountFile obj = new accountFile();
                ArrayList accounts = obj.readAllSavingAccount(); //array list: saves diffeent types of objects
                
                int totalAccounts = accounts.Count; //built-in count list function
                bool found = false;

                for (int i = 0; i < totalAccounts; i++)
                {
                    if ((accounts[i] as savingAccount).accountNoProperty == accnum)
                    {
                        found = true;
                        Console.WriteLine("\nAccount Found.\n");

                        Console.Write("\nAccount Number:");
                        Console.Write((accounts[i] as savingAccount).accountNoProperty);

                        Console.Write("\nAccount Title:");
                        Console.Write((accounts[i] as savingAccount).accountTitleProperty);

                        Console.Write("\nCNIC:");
                        Console.Write((accounts[i] as savingAccount).cnicProperty);

                        Console.Write("\nContact Number:");
                        Console.Write((accounts[i] as savingAccount).contactNoProperty);

                        Console.Write("\nAccount Balance:");
                        Console.Write((accounts[i] as savingAccount).balanceProperty);

                        Console.WriteLine("\nProfit Percentage:");
                        Console.Write((accounts[i] as savingAccount).profitPercentageProperty);
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid Input\n");
            }
        }

        public void transaction()
        {
            Console.Write("\nChoose Account Type:\n");
            Console.Write("1.Current Account.   2.Saving Account.\n");
            int num = int.Parse(Console.ReadLine());

            if (num == 1)
            {
                Console.WriteLine("\nEnter Account Number:");
                string accnum = Console.ReadLine();

                accountFile obj = new accountFile();
                List<currentAccount> accounts = obj.readAllCurrentAccount(); //simple list: saves same type of objects
                int totalAccounts = accounts.Count; //built-in count list function
                bool found = false;

                for (int i = 0; i < totalAccounts; i++)
                {
                    if (accounts[i].accountNoProperty == accnum)
                    {
                        found = true;
                        Console.WriteLine("\nAccount Found.\n");

                        Console.Write("\nChoose Transaction Type:\n");
                        Console.Write("1.Deposit Amount.   2.Withdraw Amount.\n");
                        int option = int.Parse(Console.ReadLine());

                        if (option == 1)
                        {
                            Console.Write("Enter Deposit Amount:\n");
                            int depositAmount = int.Parse(Console.ReadLine());
                            accounts[i].balanceProperty = (accounts[i].balanceProperty + depositAmount);
                            accounts[i].deposit(depositAmount);
                        }
                        if (option == 2)
                        {
                            Console.Write("Enter Withdrawal Amount:\n");
                            int withdrawalAmount = int.Parse(Console.ReadLine());
                            if (withdrawalAmount <= accounts[i].withdrawalLimitProperty)
                            {
                                accounts[i].balanceProperty = (accounts[i].balanceProperty + withdrawalAmount);
                                accounts[i].withdraw(withdrawalAmount);
                            }
                            else
                            {
                                Console.Write("ERROR!!! Amount more than Withdrawal Limit.\n");
                            }
                        }
                    }
                }

                StreamWriter writeCurrent = new StreamWriter("CurrentAccount.txt"); //write to file object
             
                for (int j = 0; j < totalAccounts; j++)
                {
                    currentAccount account = accounts[j];
                    writeCurrent.WriteLine(account.accountNoProperty);
                    writeCurrent.WriteLine(account.accountTitleProperty);
                    writeCurrent.WriteLine(account.balanceProperty);
                    writeCurrent.WriteLine(account.cnicProperty);
                    writeCurrent.WriteLine(account.contactNoProperty);
                    writeCurrent.WriteLine(account.withdrawalLimitProperty);
                }
                writeCurrent.Close();
                return;
            }

            else if (num == 2)
            {
                Console.WriteLine("\nEnter Account Number:");
                string accnum = Console.ReadLine();

                accountFile obj = new accountFile();
                ArrayList accounts = obj.readAllSavingAccount(); //array list: saves diffeent types of objects
                
                int totalAccounts = accounts.Count; //built-in count list function
                bool found = false;

                for (int i = 0; i < totalAccounts; i++)
                {
                    if ((accounts[i] as savingAccount).accountNoProperty == accnum)
                    {
                        found = true;
                        Console.WriteLine("\nAccount Found.\n");

                        Console.Write("\nChoose Transaction Type:\n");
                        Console.Write("1.Deposit Amount.   2.Withdraw Amount.\n");
                        int option = int.Parse(Console.ReadLine());

                        if (option == 1)
                        {
                            Console.Write("Enter Deposit Amount:\n");
                            int depositAmount = int.Parse(Console.ReadLine());
                            (accounts[i] as savingAccount).balanceProperty = ((accounts[i] as savingAccount).balanceProperty + depositAmount);
                            (accounts[i] as savingAccount).deposit(depositAmount);
                        }
                        if (option == 2)
                        {
                            Console.Write("Enter Withdrawal Amount:\n");
                            int withdrawalAmount = int.Parse(Console.ReadLine());
                            (accounts[i] as savingAccount).balanceProperty = ((accounts[i] as savingAccount).balanceProperty + withdrawalAmount);
                            (accounts[i] as savingAccount).withdraw(withdrawalAmount);
                        }
                    }
                }

                StreamWriter writeSaving = new StreamWriter("SavingAccount.txt"); //write to file object
                
                for (int j = 0; j < totalAccounts; j++)
                {
                    savingAccount account = accounts[j] as savingAccount;
                    writeSaving.WriteLine(account.accountNoProperty);
                    writeSaving.WriteLine(account.accountTitleProperty);
                    writeSaving.WriteLine(account.balanceProperty);
                    writeSaving.WriteLine(account.cnicProperty);
                    writeSaving.WriteLine(account.contactNoProperty);
                    writeSaving.WriteLine(account.profitPercentageProperty);
                }
                writeSaving.Close();
                return;
            }
            else
            {
                Console.WriteLine("Invalid Input\n");
            }
        }
    }
}