using System;
using System.Collections.Generic;

namespace Banking
{
    internal class BankServices
    {
        private BankResources bankResources;
        private List<Holder> masterHolder;
        private List<Account> closedAccounts;
        private List<Account> accounts;

        internal BankServices(BankResources resource)
        {
            bankResources = resource;
            masterHolder = new List<Holder>();
            closedAccounts = new List<Account>();
        }

        internal void newHolderForImport(Holder h)
        {
            masterHolder.Add(h);
        }

        internal void newAccount(Holder h, Account a)
        {
            masterHolder.Add(h);
            h.setID(bankResources.getNextHolderID());
            h.addNewAccount(a);
            a.addNewAccountHolder(h);
            a.setOpenDate(DateTime.Now);
            a.setAccountNumber(bankResources.nextAccountNumber());
        }

        internal void closeAccount(Account a)
        {
            if (!a.isClosed())
            {
                a.closeAccount(true);
                closedAccounts.Add(a);
            }
        }

        internal List<Holder> getMasterHolderList()
        {
            return masterHolder;
        }

        internal List<Account> getAccountList()
        {
            accounts = new List<Account>();
            foreach (Holder h in masterHolder)
            {
                foreach(Account a in h.getAccountList())
                {
                    accounts.Add(a);
                }
            }
            return accounts;
        }
    }
}