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
            string theString;
            theString = getString();



            string string1 = theString.Replace(' ', '_'); // Replaced space with underscore
            string string2 = theString.TrimStart();       // Remove spaces at start
            string string3 = theString.TrimEnd();         // Remove spaces at the end
            string string4 = theString.Replace('a', 'A'); // Replace lowecase a with uppercase A

            Console.WriteLine();
            Console.WriteLine(string1);
            Console.WriteLine(string2);
            Console.WriteLine(string3);
            Console.WriteLine(string4);

        }
    }
}
