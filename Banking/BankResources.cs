namespace Banking
{
    internal class BankResources
    {
        private long accountNumber;
        private long holderID;

        internal BankResources()
        {
            accountNumber = 1000;
        }

        internal void setAccountNumStarter(long startingCustNum)
        {
            this.accountNumber = startingCustNum;
        }

        internal long nextAccountNumber()
        {
            ++accountNumber;
            return accountNumber;
        }

        internal long getNextHolderID()
        {
            ++holderID;
            return holderID;
        }

        internal long getOverdraftFee()
        {
            return 36;
        }

        internal void setHolderIDStarter(long startingHolderID)
        {
            this.holderID = startingHolderID;
        }
    }
}