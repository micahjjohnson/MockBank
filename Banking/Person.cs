using System;
using System.Globalization;
using System.Text;

namespace Banking
{
    internal class Person
    {
        protected Address address;
        protected string firstName;
        protected string lastName;
        protected string phone;
        protected string email;

        internal void setPersonDetails(string first, string last, string phone, string email)
        {
            this.firstName = first;
            this.lastName = last;
            this.phone = phone.Trim();
            this.email = email;
        }

        internal string AddressLabel()
        {
            StringBuilder addLabel = new StringBuilder();
            addLabel.Append(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(firstName) + " ");
            addLabel.Append(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(lastName) + "\n");
            addLabel.Append(address.Label());
            return addLabel.ToString();
        }

        internal Address getAddress()
        {
            return address;
        }

        internal string getFormattedPhone()
        {
            return String.Format("{0:(###) ###-####}", double.Parse(phone));
        }

        internal string getFullName()
        {
            return firstName + " " + lastName;
        }

        internal void setAddress(string lineOne, string lineTwo, string city, string st, string zip)
        {
            this.address = new Address(lineOne, lineTwo, city, st, zip);
        }

        internal string getFirstName()
        {
            return firstName;
        }

        internal string getLastName()
        {
            return lastName;
        }

        internal string getPhone()
        {
            return phone;
        }

        internal string getEmail()
        {
            return email;
        }
    }
}