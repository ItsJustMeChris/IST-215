using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Linq_List
{
    class PersonList
    {
        private List<Person> people = new List<Person>();

        public List<Person> all()
        {
            return this.people;
        }

        public List<Person> FindByLastName(string lastName)
        {
            var person = from p in this.people where p.lastName == lastName select p;
            return person.ToList();
        }

        public void add(Person p)
        {
            this.people.Add(p);
        }

        public List<Person> FindByFirstName(string firstName)
        {
            var person = from p in this.people where p.firstName == firstName select p;
            return person.ToList();
        }

        public List<Person> FindByPerson(Person personObj)
        {
            var person = from p in this.people where p == personObj select p;
            return person.ToList();
        }

        public List<Person> FindFromCity(string city)
        {
            var person = from p in this.people where p.city == city select p;
            return person.ToList();
        }

        public List<Person> FindFromCityState(string city, string state)
        {
            var person = from p in this.people where p.city == city && p.state == state select p;
            return person.ToList();
        }


        public List<Person> FindFromLastNameAndState(string lastName, string state)
        {
            var person = from p in this.people where p.lastName == lastName && p.state == state select p;
            return person.ToList();
        }
    }
}
