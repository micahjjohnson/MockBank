using System;

namespace Banking
{
    internal class AccountServices
    {
        private readonly BankResources bankResources;

        internal AccountServices() { }

        internal AccountServices(BankResources b)
        {
            this.bankResources = b;
        }

        internal bool accountIsOverdrawn(Account a)
        {
            {
                if (a.getBalance() < 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        internal void deposit(Account a, decimal x, int method)
        {
            if (method == 1)
            {
                a.newActivity(new Activity(DateTime.Now, Type.DEPOSIT, x));
            }
        }

        internal void creditAccount(Account a, decimal x)
        {
            a.newActivity(new Activity(DateTime.Now, Type.CREDIT, x));
        }

        internal void transferFunds(Account from, Account to, decimal x)
        {
            from.newActivity(new Activity(DateTime.Now, Type.TRANSFER, x));
            to.newActivity(new Activity(DateTime.Now, Type.TRANSFER_RECEIVE, x));
        }

        internal void withdraw(Account a, decimal x)
        {
            var verification = new VerifyMoney(a, x);

            if (verification.Approval)
            {
                a.newActivity(new Activity(DateTime.Now, Type.WITHDRAWAL, x));

                if (verification.Overdrawn)
                {
                    var activity = new Activity(DateTime.Now, Type.FEE, bankResources.getOverdraftFee());
                    activity.Description = "Overdraft Fee";
                    a.newActivity(activity);
                    //a.newRecord(new OverdraftRecord(a));
                }
            }
            else
            {
                /* DECLINE */
                a.newActivity(new Activity(DateTime.Now, Type.DECLINE, x));
            }
        }
    }
}