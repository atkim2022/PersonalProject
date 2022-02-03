using System;
using System.Collections.Generic; // Feedback(jcollard 2022-01-28): This allows us to use List
using System.Linq; // Feedback(jcollard 2022-01-28): This allows us to use call "ToList" on files
using System.IO; // Feedback(jcollard 2022-01-28): This allows us to load files

namespace PersonalProject
{
    class TestDisplayInfo
    {
        public static bool RunTest()
        {
            string info = Program.DisplayInfo("accuracy");
        // 1. Validate that the guess and correct word are the same length
        // 2. If the lengths do not match, throw an exception
        // 3. If they match, iterate through each character:
        // 4. Use the DisplayCharInfo method to determine what color to print the character

        // TODO(jcollard 2022-02-01): Think about calling the method Program.DisplayCharInfo
            // What are different arguments that you could pass to the method?
            // What would the different results be?
            // What happens if you pass the arguments 'c', 1, "accuracy"?
            // What happens if you pass the arguments 'a', 0, "banana"?
            // What happens if you pass the arguments 'f', 3, "joker"?

            return true;
        }
    }

}