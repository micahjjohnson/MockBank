using System;

namespace Banking
{
    public enum Type
    {
        TRANSACTION, DEPOSIT, WITHDRAWAL, BALANCE, FEE, NOTE, PAYMENT, DECLINE, CREDIT, TRANSFER_RECEIVE, TRANSFER
    }

    public class Activity
    {
        private DateTime date_time;
        private readonly Type type;
        private bool adjusted;
        private readonly decimal amount;
        private decimal balanceNow;
        private int status;

        public DateTime Date { get { return date_time; } }
        public Type Type { get { return type; } }
        public decimal Amount { get { return amount; } }
        public decimal BalanceNow { get { return balanceNow; } }
        public int Status { get  {  return status; } }

        public string Description { get; internal set; }

        public Activity(DateTime date, Type t, decimal y)
        {
            this.date_time = date;
            this.type = t;
            if (y >= 0)
            {
                this.amount = Decimal.Round(y, 2);
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
            updateStatus(3); //pending 
        }

        public void updateBalance(decimal x)
        {
            this.balanceNow = x;
        }

        public void updateStatus(int x)
        {
            if (x > 0 && x < 4) { this.status = x; }
            else { this.status = 3; }
        }

        internal void adjustActivity(bool x)
        {
            adjusted = x;
        }

        internal bool getAdjustedValue()
        {
            return adjusted;
        }

        internal string data()
        {
            return date_time.ToShortDateString() + "\t" + Description + "\t" + type + "\t$" + amount;
        }
    }
}