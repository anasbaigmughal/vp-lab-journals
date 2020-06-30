using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

namespace ConsoleApplication1
{
    class accountFile
    {
        public void writeAllSavingAccount(ArrayList sa)
        {
            StreamWriter writeSaving = new StreamWriter("SavingAccount.txt"); //write to file object
            int totalAccount = sa.Count;

            for (int i = 0; i < totalAccount; i++)
            {
                savingAccount account = sa[i] as savingAccount;
                writeSaving.WriteLine(account.accountNoProperty);
                writeSaving.WriteLine(account.accountTitleProperty);
                writeSaving.WriteLine(account.balanceProperty);
                writeSaving.WriteLine(account.cnicProperty);
                writeSaving.WriteLine(account.contactNoProperty);
                writeSaving.WriteLine(account.profitPercentageProperty);
            }
            writeSaving.Close();
        }

        public void writeAllCurrentAccount(List<currentAccount> ca)
        {
            StreamWriter writeCurrent = new StreamWriter("CurrentAccount.txt"); //write to file object
            int totalAccount = ca.Count;

            for (int i = 0; i < totalAccount; i++)
            {
                currentAccount account = ca[i];
                writeCurrent.WriteLine(account.accountNoProperty);
                writeCurrent.WriteLine(account.accountTitleProperty);
                writeCurrent.WriteLine(account.balanceProperty);
                writeCurrent.WriteLine(account.cnicProperty);
                writeCurrent.WriteLine(account.contactNoProperty);
                writeCurrent.WriteLine(account.withdrawalLimitProperty);
            }
            writeCurrent.Close();
        }

        public ArrayList readAllSavingAccount()
        {
            StreamReader read = new StreamReader("SavingAccount.txt"); //read from file object
            ArrayList savingAccount = new ArrayList();
            savingAccount sv = null;

            while (!read.EndOfStream)
            {
                string Ac = read.ReadLine();
                string At = read.ReadLine();
                double bal = double.Parse(read.ReadLine());
                string cnic = read.ReadLine();
                string cn = read.ReadLine();
                float pp = float.Parse(read.ReadLine());
                sv = new savingAccount(Ac, At, cnic, cn, bal, pp);
                savingAccount.Add(sv);
            }
            read.Close();
            return savingAccount;
        }

        public List<currentAccount> readAllCurrentAccount()
        {
            StreamReader read = new StreamReader("CurrentAccount.txt"); //read from file object
            List<currentAccount> currentAccount = new List<currentAccount>();
            currentAccount ca = null;

            while (!read.EndOfStream)
            {
                string Ac = read.ReadLine();
                string At = read.ReadLine();
                double bal = double.Parse(read.ReadLine());
                string cnic = read.ReadLine();
                string cn = read.ReadLine();
                double wl = double.Parse(read.ReadLine());
                ca = new currentAccount(Ac, At, cnic, cn, bal, wl);
                currentAccount.Add(ca);
            }
            read.Close();
            return currentAccount;
        }
    }
}