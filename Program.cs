using System;

namespace PersonalProject
{
    class Program
    {
        static void Main(string[] args)
        {

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
            return null;
        }

        /// <summary>
        /// Asks the user to make a guess and validates the input before returning the guess.
        /// </summary>
        /// <param name="correctWord">The correct word that the player is guessing.</param>
        /// <returns>The player's inputted guess</returns>
        static string GetGuess(string correctWord)
        {
        // 1. Prompt the user to make a guess
        // 2. Read input from the keyboard and store the results in a variable named guess
        // 3. If guess is the correct length (the guess and random word should be the same length), return the guess.
        // 4. Otherwise, display an error message and ask them to make another guess.
            return null;
        }

        /// <summary>
        /// Given a guess and the correct word to be guessed, displays the guess to the screen coloring each character 
        /// based on its position and if it is in the correct word.
        /// </summary>
        /// <param name="guess">The player's guess</param>
        /// <param name="correct">The correct word to guess</param>
        void DisplayInfo(string guess, string correct)
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
        void DisplayCharInfo(char guess, int pos, string correct)
        {
        // 1. If the guess is in the correct position, select the color green.
        // 2. If the guess is in the correct word but not correct position, select yellow.
        // 3. If the guess is not in the correct word, select red.
        // 4. Display the guess
        // 5. Reset the color back to white before returning
        }


    }
}
