using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20sep2017t003
{
    class account
    {
        protected string accountNo;
        protected string accountTitle;
        protected string cnic;
        protected string contactNo;
        protected double balance;

        public account()
        {
        }

        public account( string accountNo, string accountTitle, string cnic, string contactNo, double balance )
        {
            this.accountNo = accountNo;
            this.accountTitle = accountTitle;
            this .cnic = cnic;
            this.contactNo = contactNo;
            this.balance = balance;
        }

        public virtual double withdraw(double amount)
        {
            return this.balance -= amount;
        }
        public virtual double deposit( double amount )
        {
            return this.balance += amount;
        }
    }
}
