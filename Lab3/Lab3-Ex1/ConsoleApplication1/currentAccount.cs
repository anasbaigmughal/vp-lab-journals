using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class currentAccount : account //inheritence
    {
        private double withdrawalLimit; //extra variable to store withdrawal limit

        public currentAccount()
        {
        }

        public currentAccount( string accountNo, string accountTitle, string cnic, string contactNo, double balance, double withdrawalLimit )
            : base(accountNo, accountTitle, cnic, contactNo, balance) //base class parametrized constructor call combine with child class
        {
            this.withdrawalLimit = withdrawalLimit;
        }

        public string accountNoProperty //C# property: just like get set method
        {
            get { return accountNo; }
            set { accountNo = value; }
        }

        public string accountTitleProperty //C# property: just like get set method
        {
            get { return accountTitle; }
            set { accountTitle = value; }
        }

        public string cnicProperty //C# property: just like get set method
        {
            get { return cnic; }
            set { cnic = value; }
        }

        public string contactNoProperty //C# property: just like get set method
        {
            get { return contactNo; }
            set { contactNo = value; }
        }

        public double balanceProperty //C# property: just like get set method
        {
            get { return balance; }
            set { balance = value; }
        }

        public double withdrawalLimitProperty //C# property: just like get set method
        {
            get { return withdrawalLimit; }
            set { withdrawalLimit = value; }
        }

        public override double deposit(double amount) //virtual funtion overridden in child class
        {
            return base.deposit(amount);
        }

        public override double withdraw(double amount) //virtual funtion overridden in child class
        {
            if (amount <= this.withdrawalLimit)
            {
                return base.withdraw(amount);
            }
            return -1;
        }
    }
}