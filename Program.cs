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

            // TODO(jcollard 2022-02-11): After you have finished all of your
            // methods, you will put your actual program logic here where you
            // connect all of the parts together.
            //
            // In your case you would have something like this:
            // 1. Displays a Welcome Message
            // 2. A random word is then generated (GetRandomWord)
            // while (the-game-is-not-won)
            // 3. The player is asked to make a guess (GetGuess)
            // 4. If the guess is correct, the player wins
            // 5. If the guess is incorrect:
            //     - The player receives information based on their guess (DisplayInfo)
            //     - The game continues to step 3
        }

        public static void TestAll()
        {
            bool testGetRandomWord = TestGetRandomWord.RunTest();
            Console.WriteLine($"GetRandomWord(): {testGetRandomWord}");

            bool testGetGuess = TestGetGuess.RunTest();
            Console.WriteLine($"TestGetGuess(string correctWord): {testGetGuess}");

            bool testDisplayCharInfo = TestDisplayCharInfo.RunTest();
            Console.WriteLine($"TestDisplayCharInfo(char guess, int pos, string correct): {testDisplayCharInfo}");

            bool testDisplayInfo = TestDisplayInfo.RunTest();
            Console.WriteLine($"TestDisplayInfo(string guess, string correct): {testDisplayInfo}");
        }




        /// <summary>
        /// Randomly generates a random word to be guessed.
        /// </summary>
        /// <returns>The word at position 'ix'</returns>
        public static string GetRandomWord()
        {        
            // Feedback(jcollard 2022-02-08): To generate a random word you need
            // to use the Random class. I've added a demo for you here:
            // https://dotnetfiddle.net/vREaLH

            Console.WriteLine("Welcome to Wordle!");
            List<string> words = File.ReadAllLines("words.txt").ToList();
            Random r = new Random();
            int randomIndex = r.Next(0, words.Count);
            string correctWord = words[randomIndex];
            // TODO(jcollard 2022-02-11): This method simply generates a random
            // work and returns it The code below should be part of your Main
            // method.
            Console.WriteLine("The word is 5 letters long.");
            Console.WriteLine("Input guess:");
            string guess = Console.ReadLine();
            
            if (guess == correctWord)
            {
                //WIN
            }

            else 
            {
                //CALLS CHAR INFOR STUFF
            }
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
            string guess = Console.ReadLine();
           
            // TODO(jcollard 2022-02-11): This method should read user input
            // and verify that it is a valid input. If it is not, this method
            // should loop and get another prompt.
            //
            // We did this in the Console Guessing Game project. I would start
            // by reviewing my code there.

            if (guess.Length != 5)
                {
                    Console.Error.WriteLine("Your guess should be 5 letters long. Make a valid guess.");
                }
            else if (guess == correctWord) 
                {
                    // Feedback(jcollard 2022-02-11): This method should only
                    // validate the user input. It doesn't check if the guess
                    // was correct. This will be done in your Main method.
                   Console.WriteLine("You won! You guessed the correct word.");
                }

            return guess; 
        }

       
        /// <summary>
        /// Given a guess and the correct word to be guessed, displays the guess to the screen coloring each character 
        /// based on its position and if it is in the correct word.
        /// </summary>
        /// <param name="guess">The player's guess</param>
        /// <param name="correct">The correct word to guess</param>
        public static void DisplayInfo(string guess, string correctWord)
        {
            if (guess.Length != correctWord.Length)
            {
                throw new exception ($"expected {guess} and {correctWord} to have the same length."); // TODO(jcollard 2022-02-11): Change to `Exception` with a capital E
            }

            int pos = 0; 

            while (pos < correctWord.Length)
            {
                  guessChar = guess[pos]; // TODO(jcollard 2022-02-11): Change to `char guessChar = guess[pos];`
                  correctChar = correctWord[pos]; // TODO(jcollard 2022-02-11): I don't think you need this line
                  // TODO(jcollard 2022-02-11): Try `DisplayCharInfo(guessChar, pos, correctWord)`
                  //something that calls char info? 
                  pos ++; 
            }

            return;
        }

        
        /// <summary>
        /// Given a guessed character, the position of that guess, and the correct word, select the correct color 
        /// for the guess and write it to the console.
        /// </summary>
        /// <param name="guess">The player's inputted guess</param>
        /// <param name="pos">The position of the characters in the guess</param>
        /// <param name="correct">The correct word to guess</param>
        public static void DisplayCharInfo(char guess, int pos, string correctWord)
        {
            if (guess == correctWord[pos])
            {
                Console.WriteLine(guess[pos]); // TODO(jcollard 2022-02-11): Try `Console.Write(guess)`
                Console.ForegroundColor = ConsoleColor.Green; // TODO(jcollard 2022-02-11): You need to set the color
            }

            if else (correctWord.Containsguess) // TODO(jcollard 2022-02-11): Try `else if (correctWord.Contains(guess))`
            {
                Console.WriteLine(guess[pos]); // TODO(jcollard 2022-02-11): Try `Console.Write(guess)`
                Console.ForegroundColor = ConsoleColor.Yellow;
            }

            else 
            {
                Console.WriteLine(guess[pos]); // TODO(jcollard 2022-02-11): Try `Console.Write(guess)`
                Console.ForegroundColor = ConsoleColor.Red;
            }

            // DISPLAY GUESS
            // TODO(jcollard 2022-02-11): Set the console color back to White when you're done
        }
    }
}

