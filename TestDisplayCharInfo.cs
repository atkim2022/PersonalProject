using System;
using System.Collections.Generic; // Feedback(jcollard 2022-01-28): This allows us to use List
using System.Linq; // Feedback(jcollard 2022-01-28): This allows us to use call "ToList" on files
using System.IO; // Feedback(jcollard 2022-01-28): This allows us to load files

namespace PersonalProject
{
    class TestDisplayCharInfo
    {
        public static bool RunTest()
        {
        // 1. If the guess is in the correct position, select the color green.
        // 2. If the guess is in the correct word but not correct position, select yellow.
        // 3. If the guess is not in the correct word, select red.
        // 4. Display the guess
        // 5. Reset the color back to white before returning

        Console.WriteLine("You should see a green 'c'");
            Program.DisplayCharInfo('c', 0, "color");

            Console.WriteLine("You should see a yellow 'c'");
            Program.DisplayCharInfo('c', 1, "color");


            Console.WriteLine("Did all of the outputs look correct? Type 'y'");
            string input = Console.ReadLine();
            if (input != "y"){
                return false;
            }
            return false;

            // just repeat for more scenarios
        }
    }

}