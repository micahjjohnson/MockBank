using System.Collections.Generic;

namespace Banking
{
    internal class Search
    {
        private List<Account> results;
        private List<Holder> results2;
        private List<Activity> activityResults;

        public List<Account> AccountSearchResults
        {
            get { return results; }
        }

        public List<Holder> HolderSearchResults
        {
            get { return results2; }
        }

        public List<Activity> ActivitySearchResults
        {
            get { return activityResults; }
        }

        internal bool accountIsFound()
        {
            if (results.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        internal bool HolderIsFound()
        {
            if (results2.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        internal class SearchThroughAccount : Search
        {
            public void ForDataString(BankServices b, string query)
            {
                results = new List<Account>();
                foreach (Account a in b.getAccountList())
                {
                    if (a.data().Contains(query))
                    {
                        results.Add(a);
                    }
                }
            }

            public void ForAccountNumber(BankServices b, long query)
            {
                results = new List<Account>();
                foreach (Account a in b.getAccountList())
                {
                    if (a.getAccountNumber().ToString().Contains(query.ToString()))
                    {
                        results.Add(a);
                    }
                }
            }

            internal void ForExactAccountNumber(BankServices b, long query)
            {
                results = new List<Account>();
                foreach (Account a in b.getAccountList())
                {
                    if (a.getAccountNumber().ToString().Equals(query.ToString()))
                    {
                        results.Add(a);
                    }
                }
            }
        }

        internal class SearchForActivity : Search
        {
            internal void ForDataString(Account a, string query)
            {
                activityResults = new List<Activity>();
                foreach (Activity ac in a.getActivity())
                {
                    if (ac.data().Contains(query))
                    {
                        activityResults.Add(ac);
                    }
                }
            }
        }

        internal class SearchForHolder : Search
        {
            internal SearchForHolder(BankServices b, string query)
            {
                results2 = new List<Holder>();
                foreach (Holder h in b.getMasterHolderList())
                {
                    if (h.getFullName().ToLower().Contains(query.ToLower()))
                    {
                        results2.Add(h);
                    }
                }
            }
        }
    }
}
