using System.Collections.Generic;

namespace Banking
{
    internal class Holder : Person
    {
        private List<Account> accounts;
        private long id;

        internal Holder()
        {
            accounts = new List<Account>();
        }

        internal List<Account> getAccountList()
        {
            return accounts;
        }

        internal void addNewAccount(Account a)
        {
            accounts.Add(a);
        }

        internal long getID()
        {
            return id;
        }

        internal void setID(long v)
        {
            this.id = v;
        }
    }
}
