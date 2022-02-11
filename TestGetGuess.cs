using System;
using System.Collections.Generic; // Feedback(jcollard 2022-01-28): This allows us to use List
using System.Linq; // Feedback(jcollard 2022-01-28): This allows us to use call "ToList" on files
using System.IO; // Feedback(jcollard 2022-01-28): This allows us to load files

namespace PersonalProject
{
    class TestGetGuess
    {
        public static bool RunTest()
        {
        // 1. Prompt the user to make a guess
        // 2. Read input from the keyboard and store the results in a variable named guess
        // 3. If guess is the correct length (the guess and random word should be the same length), return the guess.
        // 4. Otherwise, display an error message and ask them to make another guess.
        Console.WriteLine("Testing GetGuess. You should see a prompt asking you to enter a guess.");
        Console.WriteLine("1. Enter 'go'. This should result in an invalid message saying the word is too short.");
        Console.WriteLine("2. Enter 'actually'. This should result in an invalid message saying the word is too long.");
        Console.WriteLine("3. Enter 'spoon'. This should work.");
        
            // Console.WriteLine("Input 'banana'.");
            // Console.WriteLine("The program should fail because it is not 5 characters long.");

            string guess = Program.GetGuess("angry");
            string expected = "spoon";
            if(guess != expected)
            {
                Console.Error.WriteLine($"Expected {expected} but result was {guess}");
                return false;
            }


            Console.WriteLine("3. Enter 'gravy'. This should work.");
            guess = Program.GetGuess("angry");
            string expected2 = "gravy";
            if(guess != expected2)
            {
                Console.Error.WriteLine($"Expected {expected2} but result was {guess}");
                return false;
            }

            return true;
        }
    }

}