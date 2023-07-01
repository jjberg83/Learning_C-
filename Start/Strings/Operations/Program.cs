using System;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare some strings for the exercises
            string outstr;
            string str1 = "The quick brown fox jumps over the lazy dog.";
            string str2 = "This is a string";
            string str3 = "THIS is a STRING";
            string[] strs = {"one", "two", "three", "four"};

            // TODO: Length of a string 
            Console.WriteLine($"Lengden av str1 er {str1.Length}");

            // TODO: Access individual characters
            Console.WriteLine(str1[0]);
            Console.WriteLine(str1[2]);

            // TODO: iterate over a string like any other sequence of values
            foreach(char c in str1) {
                Console.Write(c);
                if (c=='b') {
                    Console.WriteLine();
                    break;
                }
            }

            // TODO: String Concatenation         
            outstr = String.Concat(strs);
            Console.WriteLine(outstr);

            // TODO: Joining strings together with Join
            outstr = String.Join(".", strs);
            Console.WriteLine(outstr);

            // TODO: String Comparison
            // Compare will perform an ordinal comparison and return:
            // < 0 : first string comes before second in sort order
            // 0 : first and second strings are same position in sort order
            // > 0 : first string comes after the second in sort order
            int result = String.Compare(str2, "This is a string");
            Console.WriteLine(result);

            // TODO: Equals just returns a regular Boolean
            bool twins = String.Equals(str2, str3);
            Console.WriteLine(twins);
            // Kan også skrives slik:
            twins = str2.Equals(str3);
            Console.WriteLine(twins);

            // TODO: String Searching
            Console.WriteLine(str1.IndexOf("e")); // returnerer første instans av e
            Console.WriteLine(str1.LastIndexOf("e"));

            outstr = str1.Replace("fox", "cat");
            Console.WriteLine($"Outstr er nå: {outstr}");
            Console.WriteLine($"str1 er nå: {str1}");
            Console.WriteLine(outstr.IndexOf("fox"));

        }
    }
}
