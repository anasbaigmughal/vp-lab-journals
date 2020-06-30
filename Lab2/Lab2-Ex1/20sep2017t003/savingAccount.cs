using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20sep2017t003
{
    class savingAccount:account
    {
        private float profitPercentage;

        public savingAccount()
        {
        }
        public savingAccount( string accountNo, string accountTitle, string cnic, string contactNo, double balance, float profitPercentage ):base( accountNo, accountTitle, cnic, contactNo, balance )
        {
            this.profitPercentage = profitPercentage;
        }

        public string accountNoProperty
        {
            get { return accountNo; }
            set { accountNo = value; }
        }
        public string accountTitleProperty
        {
            get { return accountTitle; }
            set { accountTitle = value; }
        }
        public string cnicProperty
        {
            get { return cnic; }
            set { cnic = value; }
        }
        public string contactNoProperty
        {
            get { return contactNo; }
            set { contactNo = value; }
        }
        public double balanceProperty
        {
            get { return balance; }
            set { balance = value; }
        }
        public float profitPercentageProperty
        {
            get { return profitPercentage; }
            set { profitPercentage = value; }
        }

        public override double deposit(double amount)
        {
            if (amount >= 10000)
            {
                profitPercentage++;
            }
            return base.deposit(amount);
        }
        public override double withdraw( double amount )
        {
            if ( amount >= 10000 )
            {
                profitPercentage--;
            }
            return base.withdraw(amount);
        }
    }
}
