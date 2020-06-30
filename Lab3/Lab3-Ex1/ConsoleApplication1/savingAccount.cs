using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class savingAccount : account //inheritence
    {
        private float profitPercentage; //extra variable to store profit percentage

        public savingAccount()
        {
        }

        public savingAccount( string accountNo, string accountTitle, string cnic, string contactNo, double balance, float profitPercentage )
            : base(accountNo, accountTitle, cnic, contactNo, balance) //base class parametrized constructor call combine with child class
        {
            this.profitPercentage = profitPercentage;
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

        public float profitPercentageProperty //C# property: just like get set method
        {
            get { return profitPercentage; }
            set { profitPercentage = value; }
        }

        public override double deposit(double amount) //virtual funtion overridden in child class
        {
            if (amount >= 10000)
            {
                profitPercentage++;
            }
            return base.deposit(amount);
        }

        public override double withdraw(double amount) //virtual funtion overridden in child class
        {
            if (amount >= 10000)
            {
                profitPercentage--;
            }
            return base.withdraw(amount);
        }
    }
}