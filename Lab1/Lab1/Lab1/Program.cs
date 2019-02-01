using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice[] invoices =
            {
                new Invoice (83, "Electric Sander", 7, 57.98M),
                new Invoice (77, "Hammer", 76, 11.99M),
                new Invoice (56, "Jig Saw", 21, 11.00M),
                new Invoice (39, "Lawn Mower", 3, 79.50M),
                new Invoice (24, "Power Saw", 18, 99.99M),
                new Invoice (68, "Screwdrive", 106, 6.99M),
                new Invoice (7, "Sledge Hammer", 11, 21.50M),
                new Invoice (3, "Wrench", 34, 7.50M)
            };

            var sortedByDesc = from item in invoices orderby item.PartDescription select item;
            var sortedByPrice = from item in invoices orderby item.Price select item;
            var descAndQuantSortedQuant = from item in invoices orderby item.Quantity select new { item.PartDescription, item.Quantity };
            var descInvSortInv = from item in invoices orderby item.Quantity * item.Price select new { item.PartDescription, InvoiceTotal = item.Quantity * item.Price };
            var invTotBtwn = from item in invoices where item.Quantity * item.Price < 500 && item.Quantity * item.Price > 200 select new { item.PartDescription, InvoiceTotal = item.Quantity * item.Price };

            Console.WriteLine("\n\nSorted By Desc\n\n");
            foreach (var i in sortedByDesc) Console.WriteLine($"{i.PartNumber}\t{i.PartDescription}\t{i.Quantity}\t${i.Price}");
            Console.WriteLine("\n\nSorted By Price\n\n");
            foreach (var i in sortedByPrice) Console.WriteLine($"{i.PartNumber}\t{i.PartDescription}\t{i.Quantity}\t${i.Price}");
            Console.WriteLine("\n\nDescription and quantity, sorted by quantity\n\n");
            foreach (var i in descAndQuantSortedQuant) Console.WriteLine($"{i.PartDescription}\t{i.Quantity}");
            Console.WriteLine("\n\ndescription and invoice total, sorted by invoice total\n\n");
            foreach (var i in descInvSortInv) Console.WriteLine($"{i.PartDescription}\t${i.InvoiceTotal}");
            Console.WriteLine("\n\nDescription and invoice total between 200 and 500 sorted by invoice total\n\n");
            foreach (var i in invTotBtwn) Console.WriteLine($"{i.PartDescription}\t${i.InvoiceTotal}");

            Console.ReadKey();
        }
    }
}
