using System;

namespace MyPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's begin!");
            bool loopKnapp = true;
            (bool, int, string) result;
            do {
                string input = Console.ReadLine();
                result = IsPalindrome(input);
                if (input == "exit") {
                    Console.WriteLine("Spillet avsluttes.");
                    loopKnapp = false;
                } else {
                    Console.WriteLine($"Palindrom: {result.Item1}, Length: {result.Item2}, Ordet: {result.Item3}");
                }
            } while(loopKnapp);

            /* TESTS
            No 'X' in Nixon!
            A man, a plan, a Canal Panama!
            Madam, I'm Adam
            Hello World!
            */
        }

        // Define your function outside the Main function
        static (bool, int, string) IsPalindrome(string str)
        {
            // Gjør alle bokstaver små, og fjerner whitespace og punctuation
            string processedString = new string(str
            .ToLower()
            .Where(c => !char.IsWhiteSpace(c) && !char.IsPunctuation(c))
            .ToArray());


            // deler ordet opp i 2 like lange deler
            // eventuelle oddetallslengder etterlater
            // en bokstav som ikke tas med (bokstaven i midten)
            int lengde = processedString.Length;
            string firstPart = processedString.Substring(0, (lengde / 2));
            string secondPart = processedString.Substring(lengde - (lengde / 2));
            

            // Reverserer andre halvdel
            char[] strArr = secondPart.ToCharArray();
            Array.Reverse(strArr);
            string secondPartReversed = new string(strArr);

            // Litt print info
            // Console.WriteLine($"processedString -> {processedString}, Lengde: {lengde}");
            // Console.WriteLine($"Første halvdel: {firstPart}");
            // Console.WriteLine($"Andre halvdel: {secondPartReversed}");
            // Console.WriteLine("----------------------------");

            bool palindromeCheck = firstPart.Equals(secondPartReversed);
            // Console.WriteLine($"palindromeCheck -> {palindromeCheck}");
            return (palindromeCheck, str.Length, str);
        }

    }
}
