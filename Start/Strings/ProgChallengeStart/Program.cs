using System;
using System.Globalization;

namespace ProgChallengeStart
{
    class Program
    {
        static void Main(string[] args)
        {
            // Choose a random number between 0 and 20
            int theNumber = new Random().Next(20);

            // Print the game greeting and instructions
            Console.WriteLine("Let's Play 'Guess the Number'!");
            Console.WriteLine("I'm thinking of a number between 0 and 20.");
            Console.WriteLine("Enter your guess, or -1 to give up.");

            // Keep track of the number of guesses and the current user guess
            int numberOfGuesses = 0;
            bool loopButton = true;
            int theGuess;

            // Start the game and run until user quits or guesses correctly
            // HINT: You'll need a way to convert the user's input to an integer
            do {
                try
                {
                    theGuess = int.Parse(Console.ReadLine());
                    numberOfGuesses++;
                    if (theGuess == theNumber) {
                        Console.WriteLine($"Bullseye! Du klarte det på {numberOfGuesses} forsøk.");
                        loopButton = false;
                    }
                    else if (theGuess == -1)
                    {
                        Console.WriteLine("Spillet avsluttes.");
                        loopButton = false;
                    }
                    else if (theGuess < theNumber) {
                        Console.WriteLine("Nei, tallet jeg tenker på er høyere...");
                    }
                    else if (theGuess > theNumber) {
                        Console.WriteLine("Nei, tallet jeg tenker på er lavere...");
                    }
                }
                catch
                {
                    Console.WriteLine("Vennligst tast inn et helt tall mellom 0 og 20. Prøv igjen.");
                }
            }
            while (loopButton);
        }
    }
}
