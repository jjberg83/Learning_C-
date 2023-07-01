using System;
using System.Text;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            /* StringBuilder er bra når man stadig endrer på en stringvariabel.
            Uten StringBuilder vil OSet kopiere gammel string inn på ny memory location
            med de nye endringene man har gjort. */

            int jumpCount = 10;
            string[] animals = {"goats", "cats", "pigs"};

            // TODO: create a StringBuilder
            StringBuilder sb = new StringBuilder("Initial content", 200);
            
            // TODO: print some basic stats about the StringBuilder
            Console.WriteLine($"Capacity: {sb.Capacity}, Length: {sb.Length}");
            Console.WriteLine("-----------------------------------------------");

            // TODO: Add some strings to the builder using Append
            sb.Append(".The quick brown fox ");
            sb.Append("jumped over the lazy dog.");

            // TODO: AppendLine can append a line ending (altså en line break INNI sb hver gang man printer)
            // alt som gjøres med sb fra nå av, vil komme på ny linje når vi printer
            sb.AppendLine();

            // TODO: AppendFormat can be used to append formatted strings
            // Må ha FORMAT for å kunne legge inn "dynamisk" tekst
            // (dette virker ikke med bare Append)
            sb.AppendFormat("He did this {0} times.", jumpCount);
            sb.AppendLine();

            // TODO: AppendJoin can iterate over a set of values
            sb.Append("He also jumped over ");
            sb.AppendJoin(",", animals);

            // TODO: Modify the content using Replace
            sb.Replace("fox", "cat");

            // TODO: Insert content at any index
            // tallet i parentesen forteller hvilken indeks 
            // "This is the " skal settes inn ved
            // der indeksen er for hver bokstav
            // Dette blir altså satt inn helt først i stringen
            sb.Insert(0, "This is the ");

            // TODO: Convert to a single string
            Console.WriteLine(sb);
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine($"Capacity: {sb.Capacity}, Length: {sb.Length}");
            Console.WriteLine("-----------------------------------------------");
            // følgende smelter visst alt sammen til en string
            // han kaller det serialize everything into a final string
            Console.WriteLine(sb.ToString()); // klarer ikke å se forksjell fra denne og bare sb...
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine($"Capacity: {sb.Capacity}, Length: {sb.Length}");
            

        }
    }
}
