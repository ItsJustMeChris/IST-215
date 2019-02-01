using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Linq_List
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonList pl = new PersonList();
            Person micahelWilliams = new Person("Michael", "Williams", "69 Andrews Dr", "Aberdeen", "SD", "06031");
            pl.add(new Person("Daniel", "Garcia", "786 Bayview Dr", "Albany", "GA", "61200"));
            pl.add(micahelWilliams);
            pl.add(new Person("David", "Mikeani", "786 Bayview Dr", "Albany", "GA", "61200"));
            pl.add(new Person("Michael", "Rodi", "786 Bayview Dr", "Albany", "GA", "61200"));
            pl.add(new Person("Andrew", "Davis", "207 Bay Shore Rd", "Albany", "NY", "16745"));
            pl.add(new Person("Bob", "Fredwrds", "207 Bay Shore Rd", "Albany", "NY", "16745"));
            pl.add(new Person("Andrew", "Ender", "207 Bay Shore Rd", "Albany", "NY", "16745"));
            pl.add(new Person("Shane", "Mona", "207 Bay Shore Rd", "Albany", "NY", "16745"));
            pl.add(new Person("Denzel", "Levy", "207 Bay Shore Rd", "Albany", "NY", "16745"));
            pl.add(new Person("Ashtyn", "Levy", "207 Bay Shore Rd", "Albany", "NY", "16745"));

            Console.WriteLine("\nAll People");
            var all = pl.all();
            foreach (var p in all) Console.WriteLine(p);

            Console.WriteLine("\nFind By LastName");
            var davis = pl.FindByLastName("Davis");
            foreach (var p in davis) Console.WriteLine(p);

            Console.WriteLine("\nFind By Person");
            var mW = pl.FindByPerson(micahelWilliams);
            foreach (var p in mW) Console.WriteLine(p);

            Console.WriteLine("\nFind By City");
            var albanies = pl.FindFromCity("Albany");
            foreach (var p in albanies) Console.WriteLine(p);

            Console.WriteLine("\nFind By City State");
            var albaniesGA = pl.FindFromCityState("Albany", "GA");
            foreach (var p in albaniesGA) Console.WriteLine(p);

            Console.WriteLine("\nFind By LastName state");
            var levyNY = pl.FindFromLastNameAndState("Levy", "NY");
            foreach (var p in levyNY) Console.WriteLine(p);



            Console.ReadLine();
        }
    }
}
