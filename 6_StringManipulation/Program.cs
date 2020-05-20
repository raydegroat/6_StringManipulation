using System;

namespace _6_StringManipulation
{
    class Program
    {

        static string getString()
        {
            Console.WriteLine();
            Console.WriteLine("Type in a few words. Be sure to include some leading and training spaces. Then press the return key: ");

            return Console.ReadLine();
        }

        static void Main(string[] args)
        {
            string[] theString = new string[5];
            theString[0] = getString();

            

            theString[1] = theString[0].Replace(' ', '_'); // Replaced space with underscore
            theString[2] = theString[0].TrimStart();       // Remove spaces at start
            theString[3] = theString[0].TrimEnd();         // Remove spaces at the end
            theString[4] = theString[0].Replace('a', 'A'); // Replace lowecase a with uppercase A

            Console.WriteLine();

            for(int i = 0; i <= 4; i++)
            {
                Console.WriteLine(theString[i]);
            }
        }
    }
}
