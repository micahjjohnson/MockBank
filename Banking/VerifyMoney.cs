namespace Banking
{
    internal class VerifyMoney
    {
        private bool approval;
        private bool overdrawn;

        public bool Approval { get { return approval; } }
        public bool Overdrawn { get { return overdrawn; } }

        internal VerifyMoney(Account a, decimal funds)
        {
            verify(a, a.getBalance(), funds);       
        }

        private void verify(Account a, decimal acctBalance, decimal y)
        {
            if (a.getBalance() >= 0) //is not overdrawn
            {
                if (y <= acctBalance)
                {
                    this.approval = true;
                }
                if (y > acctBalance)
                {
                    if (a.hasOverdraftProtection())
                    {
                        this.approval = false;
                    }
                    else
                    {
                        this.approval = true;
                        this.overdrawn = true;
                    }
                }
            }
            else
            {
                this.approval = false;
            }
        }
    }
}
