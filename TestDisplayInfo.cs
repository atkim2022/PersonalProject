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