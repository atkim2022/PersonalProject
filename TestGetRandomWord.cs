using System;
using System.Collections.Generic; // Feedback(jcollard 2022-01-28): This allows us to use List
using System.Linq; // Feedback(jcollard 2022-01-28): This allows us to use call "ToList" on files
using System.IO; // Feedback(jcollard 2022-01-28): This allows us to load files

namespace PersonalProject
{
    class TestGetRandomWord
    {
        public static bool RunTest()
        {
        // 1. Load a filed called `words.txt`
        // 2. Store each line as a separate word in a list named `words`
        // 3. Generate a random number between 0 and `words.Count` and store the result in
        //    a variable called `ix`
        // 4. Return the word at position `ix`. (e.g. `words[ix]`)  
        
            List<string> words = File.ReadAllLines("words.txt").ToList();

            if (ix <= 0)
            {
                Console.Error.WriteLine("This position in the word.txt file doe not exist");
            }

        

            return true; 
        }
    }

}