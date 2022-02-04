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
    

            Console.WriteLine("You should see a green 'c'");
            Program.DisplayCharInfo('c', 0, "color");

            Console.WriteLine("You should see a yellow 'c'");
            Program.DisplayCharInfo('c', 1, "color");


            Console.WriteLine("Did all of the outputs look correct? Type 'y'");
            string input = Console.ReadLine();
            if (input != "y"){
                return false;
            }

            // TODO(jcollard: 2022-02-04): If you make it to the end of the test, return true
            return false;

            // just repeat for more scenarios
        }
    }

}