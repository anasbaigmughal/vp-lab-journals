using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20sep2017t003
{
    class currentAccount:account
    {
        private double withdrawalLimit;

        public currentAccount()
        {
        }
        public currentAccount( string accountNo, string accountTitle, string cnic, string contactNo, double balance, double withdrawalLimit ):base (accountNo, accountTitle, cnic, contactNo, balance )
        {
            this.withdrawalLimit = withdrawalLimit;
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
        public double withdrawalLimitProperty
        {
            get { return withdrawalLimit; }
            set { withdrawalLimit = value; }
        }

        public override double deposit(double amount)
        {
            return base.deposit(amount);
        }
        public override double withdraw( double amount )
        {
            if ( amount <= this.withdrawalLimit )
            {
                return base.withdraw( amount );
            }
            return -1;
        }
    } //end class
} //end namespace
