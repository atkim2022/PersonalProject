using System;
using System.Collections.Generic; // Feedback(jcollard 2022-01-28): This allows us to use List
using System.Linq; // Feedback(jcollard 2022-01-28): This allows us to use call "ToList" on files
using System.IO; // Feedback(jcollard 2022-01-28): This allows us to load files

namespace PersonalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // Console.ForegroundColor = ConsoleColor.Green;
            // Console.WriteLine("Hello World!");
            // Console.ForegroundColor = ConsoleColor.Red;
            // Console.WriteLine("Hello World!");

            // Console.ForegroundColor = ConsoleColor.Green;
            // Console.Write("H");
            // Console.Write("e");
            // Console.ForegroundColor = ConsoleColor.Red;
            // Console.Write("l");
            // Console.Write("l");
            // Console.ForegroundColor = ConsoleColor.White;
            // Console.Write("o");
            // Console.Write(" ");
            // Console.ForegroundColor = ConsoleColor.Blue;
            // Console.Write("W");
            // Console.ForegroundColor = ConsoleColor.DarkGreen;
            // Console.Write("o");
            // Console.ForegroundColor = ConsoleColor.DarkRed;
            // Console.Write("r");
            // Console.ForegroundColor = ConsoleColor.Magenta;
            // Console.Write("l");
            // Console.ForegroundColor = ConsoleColor.DarkMagenta;
            // Console.Write("d");

            if (args.Length > 0 && args [0] == "test")
            {
               TestAll();
               return;  
            }
        }

        public static void TestAll()
        {
            bool testDisplayCharInfo = TestDisplayCharInfo.RunTest();
            Console.WriteLine($"TestDisplayCharInfo(char guess, int pos, string correct): {testDisplayCharInfo}");

            bool testDisplayInfo = TestDisplayInfo.RunTest();
            Console.WriteLine($"TestDisplayInfo(string guess, string correct): {testDisplayInfo}");

            bool testGetGuess = TestGetGuess.RunTest();
            Console.WriteLine($"TestDisplayCharInfo(string correctWord): {testGetGuess}");

            bool testGetRandomWord = TestGetRandomWord.RunTest();
            Console.WriteLine($"TestDisplayCharInfo(): {testGetRandomWord}");

        }




        /// <summary>
        /// Randomly generates a random word to be guessed.
        /// </summary>
        /// <returns>The word at position 'ix'</returns>
        public static string GetRandomWord()
        {
        // 1. Load a filed called `words.txt`
        // 2. Store each line as a separate word in a list named `words`
        // 3. Generate a random number between 0 and `words.Count` and store the result in
        //    a variable called `ix`
        // 4. Return the word at position `ix`. (e.g. `words[ix]`)
            Console.WriteLine("Welcome to Wordle!");
            List<string> words = File.ReadAllLines("words.txt").ToList();

            // Feedback(jcollard 2022-02-08): To generate a random word you need
            // to use the Random class. I've added a demo for you here:
            // https://dotnetfiddle.net/vREaLH
            words.Count = randomint;
            Console.WriteLine("The word is 5 letters long.");
            String guess;
        
            return null;
        }

        /// <summary>
        /// Asks the user to make a guess and validates the input before returning the guess.
        /// </summary>
        /// <param name="correctWord">The correct word that the player is guessing.</param>
        /// <returns>The player's inputted guess</returns>
        public static string GetGuess(string correctWord)
        {
            Console.WriteLine("Input guess:");
            // TODO(jcollard: 2022-02-08): You need to store the value in a string. For example:
            // string userInput = Console.ReadLine();
            Console.ReadLine();
           
            if (guess.Length != 5)
            {
                 Console.Error.WriteLine("Your guess should be 5 letters long.");
            }
            
            else
            {
                if (guess = CorrectWord) // TODO(jcollard 2022-02-08): You should use `==` when comparing values.
                {
                    //game won
                }

                else 
                {
                    // keeps going
                }
        // 1. Prompt the user to make a guess
        // 2. Read input from the keyboard and store the results in a variable named guess
        // 3. If guess is the correct length (the guess and random word should be the same length), return the guess.
        // 4. Otherwise, display an error message and ask them to make another guess.
            return "spoon";
        }

        /// <summary>
        /// Given a guess and the correct word to be guessed, displays the guess to the screen coloring each character 
        /// based on its position and if it is in the correct word.
        /// </summary>
        /// <param name="guess">The player's guess</param>
        /// <param name="correct">The correct word to guess</param>
        public static void DisplayInfo(string guess, string correct)
        {
        // 1. Validate that the guess and correct word are the same length
        // 2. If the lengths do not match, throw an exception
        // 3. If they match, iterate through each character:
        // 4. Use the DisplayCharInfo method to determine what color to print the character
        }

        /// <summary>
        /// Given a guessed character, the position of that guess, and the correct word, select the correct color 
        /// for the guess and write it to the console.
        /// </summary>
        /// <param name="guess">The player's inputted guess</param>
        /// <param name="pos">The position of the characters in the guess</param>
        /// <param name="correct">The correct word to guess</param>
        public static void DisplayCharInfo(char guess, int pos, string correct)
        {
        // 1. If the guess is in the correct position, select the color green.
        // 2. If the guess is in the correct word but not correct position, select yellow.
        // 3. If the guess is not in the correct word, select red.
        // 4. Display the guess
        // 5. Reset the color back to white before returning
        }
    }
}

