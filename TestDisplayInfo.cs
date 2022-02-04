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

        // TODO(jcollard 2022-02-01): Think about calling the method Program.DisplayCharInfo
            // What are different arguments that you could pass to the method?
            // What would the different results be?
            // What happens if you pass the arguments 'c', 1, "accuracy"?
            // What happens if you pass the arguments 'a', 0, "banana"?
            // What happens if you pass the arguments 'f', 3, "joker"?

            Console.WriteLine("You should see a all red except the 1st 'o' should be green and the 2nd 'o' should be yellow.");
            Program.DisplayInfo("color", "boons");

            Console.WriteLine("You should see a all red.");
            Program.DisplayInfo("books", "drive");
            
            Console.WriteLine("You should see all green.");
            Program.DisplayInfo("drive", "drive");
            
            Console.WriteLine("Did all of the outputs look correct? Type 'y'");
            string input = Console.ReadLine();
            if (input != "y")
            {
                return false;
            }

            return true;
        }
    }

}