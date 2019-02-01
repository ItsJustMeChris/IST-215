using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentence");
            string sentence = Console.ReadLine();
            Console.WriteLine("You entered: ");
            Console.WriteLine(sentence);
            string[] spl = sentence.Split(' ');
            var a = spl.Distinct();
            Console.Write("Distinct Words: ");
            foreach (var w in a) Console.Write($"{w} ");
            Console.ReadLine();
        }
    }
}
