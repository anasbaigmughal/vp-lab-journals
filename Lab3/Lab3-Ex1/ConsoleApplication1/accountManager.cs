using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;

namespace ConsoleApplication1
{
    class accountManager
    {
        ArrayList savingAccountList = new ArrayList(); //array list: saves different types of objects
        List<currentAccount> currentAccountList = new List<currentAccount>(); //simple list: saves same type of objects

        public void createNewSavingAccount(savingAccount sa)
        {
            this.savingAccountList.Add(sa); //adding object to array list
        }

        public void createNewCurrentAccount(currentAccount ca)
        {
            this.currentAccountList.Add(ca); //adding object to simple list
        }

        public void writeAllinFile()
        {
            accountFile write = new accountFile();
            write.writeAllSavingAccount(savingAccountList);
            write.writeAllCurrentAccount(currentAccountList);
        }

        public void searchCurrentAccount(string An)
        {
            accountFile obj = new accountFile(); 
            List<currentAccount> accounts = obj.readAllCurrentAccount(); //simple list: saves same type of objects
            int totalAccounts = accounts.Count; //built-in count list function
            bool found = false;

            for (int i = 0; i < totalAccounts; i++)
            {
                if (accounts[i].accountNoProperty == An)
                {
                    found = true;
                    Console.WriteLine("\nAccount Found.\n");
                    return;
                }
            }
            Console.WriteLine("\nAccount Not Found.\n");
        }

        public void searchSavingAccount(string An)
        {
            accountFile obj = new accountFile();
            ArrayList accounts = obj.readAllSavingAccount(); //array list: saves diffeent types of objects
            int totalAccounts = accounts.Count; //built-in count list function
            bool found = false;

            for (int i = 0; i < totalAccounts; i++)
            {
                if ((accounts[i] as savingAccount).accountNoProperty == An)
                {
                    found = true;
                    Console.WriteLine("\nAccount Found.\n");
                    return;
                }
            }
            Console.WriteLine("\nAccount Not Found.\n");
        }
    }
}