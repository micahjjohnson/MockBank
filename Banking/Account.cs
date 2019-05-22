using System;
using System.Collections.Generic;

namespace Banking
{
    internal enum AcctType
    {
        CHECKING, SAVINGS
    }

    internal class Account : IIdentifyer
    {
        private readonly int MAX_ACCOUNT_HOLDERS = 2;
        private List<Holder> accountHolders;
        private List<Activity> activity;
        private DateTime openingDate;
        private DateTime closingDate;
        private AcctType acct_type;
        private long accountNumber;
        private decimal balance;
        private bool closed;
        private bool overdraftProtection;
        //private int accountType;

        internal Account()
        {
            this.accountHolders = new List<Holder>();
            this.activity = new List<Activity>();
            this.balance = 0;
        }

        internal void setOpenDate(DateTime date)
        {
            this.openingDate = date;
        }

        internal void setAccountNumber(long accountNum)
        {
            this.accountNumber = accountNum;
        }

        internal void addNewAccountHolder(Holder h)
        {
            if (accountHolders.Count <= MAX_ACCOUNT_HOLDERS)
            {
                accountHolders.Add(h);
            }
        }

        internal void closeAccount(bool x)
        {
            closed = x;
        }

        internal Holder getCardHolder(int x)
        {
            return accountHolders[x - 1];
        }

        internal List<Activity> getActivity()
        {
            return activity;
        }
        
        internal DateTime getOpenDate()
        {
            return openingDate;
        }

        internal DateTime getCloseDate()
        {
            return closingDate;
        }

        internal void newActivity(Activity a)
        {
            if (a.Type == Type.TRANSACTION || a.Type == Type.WITHDRAWAL || a.Type == Type.FEE || a.Type == Type.TRANSFER) { balance -= a.Amount; }
            if (a.Type == Type.DEPOSIT || a.Type == Type.CREDIT || a.Type == Type.TRANSFER_RECEIVE) { balance += a.Amount; }
            a.updateBalance(balance);
            activity.Add(a);
        }

        internal void removeAccountHolder(Holder h)
        {
            accountHolders.Remove(h);
        }

        internal long getAccountNumber()
        {
            return accountNumber;
        }

        internal decimal getBalance()
        {
            return balance;
        }

        internal bool isClosed()
        {
            return closed;
        }

        internal void setOverdraftProtection(bool x)
        {
            overdraftProtection = x;
        }

        internal bool hasOverdraftProtection()
        {
            return overdraftProtection;
        }     

        internal string data()
        {
            return accountNumber + "\t" + getCardHolder(1).getFullName();
        }

        public void setAccountType(AcctType type)
        {
            acct_type = type;
        }

        public AcctType getAccountType()
        {
            return acct_type;
        }
    }
}