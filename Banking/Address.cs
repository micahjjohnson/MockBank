using System.Text;

namespace Banking
{
    internal class Address
    {
        private string lineOne;
        private string lineTwo;
        private string city;
        private string state;
        private string zip;
        private string country;
        private string county;

        internal Address(string lineOne, string lineTwo, string city, string st, string zip)
        {
            this.lineOne = lineOne;
            this.lineTwo = lineTwo;
            this.city = city;
            this.state = st;
            this.zip = zip;
        }

        internal void extraDetails(string county, string country)
        {
            this.county = county;
            this.country = country;
        }

        internal string Label()
        {
            StringBuilder addlabel = new StringBuilder();
            addlabel.Append(lineOne + "\n");

            if (lineTwo.Length != 0)
            {
                addlabel.Append(lineTwo + "\n");
            }

            addlabel.Append(city + ", ");
            addlabel.Append(state + " ");
            addlabel.Append(zip);
            return addlabel.ToString();
        }

        internal string getLineOne()
        {
            return lineOne;
        }

        internal string getLineTwo()
        {
            return lineTwo;
        }

        internal string getCity()
        {
            return city;
        }

        internal string getState()
        {
            return state;
        }

        internal string getZip()
        {
            return zip;
        }
    }
}