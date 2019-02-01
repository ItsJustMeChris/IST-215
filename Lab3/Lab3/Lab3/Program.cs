using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> letters = GenerateLetters();

            Console.WriteLine("Generated List");
            foreach (var l in letters) Console.Write($"{l} ");
            var sortedAsc = from l in letters orderby l ascending select l;
            var sortedDesc = from l in letters orderby l descending select l;

            Console.WriteLine("\nSorted Ascending");
            foreach (var l in sortedAsc) Console.Write($"{l} ");

            Console.WriteLine("\nSorted Descending");
            foreach (var l in sortedDesc) Console.Write($"{l} ");

            var noDupes = sortedAsc.Distinct();
            Console.WriteLine("\nAscending, no dupes");
            foreach (var l in noDupes) Console.Write($"{l} ");

            Console.ReadLine();
        }

        static List<string> GenerateLetters()
        {
            Random rnd = new Random();
            List<string> letters = new List<string>();
            for(int i = 0; i < 20; i++)
            {
                letters.Add(((char)rnd.Next(97, 122)).ToString());
            }
            return letters;
        }
    }
}
