using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Linq_List
{
    class Person
    {
        public string firstName { get; }
        public string lastName { get; }
        public string address { get; }
        public string city { get; }
        public string state { get; }
        public string zip { get; }

        public Person(string firstName, string lastName, string address, string city, string state, string zip)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
        }

        public override string ToString()
        {
            return $"{firstName} {lastName} {address} {city} {state} {zip}";
        }

        public bool Equals(Person other)
        {
            if (other == null) return false;
            if (this == other) return true;
            if (other == null || this.GetType() != other.GetType()) return false;
            if (this.firstName == null && other.firstName !== null)
            {
                return false;
            } else if (!firstName.Equals(other.firstName))
                return false;

            if (this.lastName == null && other.lastName != null) {
                return false;
            }
            else if (!lastName.Equals(other.lastName))
                return false;

            return true;
    }
}
