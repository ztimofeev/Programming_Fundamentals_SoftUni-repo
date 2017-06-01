namespace Strings_And_Objects
{
    using System;
    public class StringsAndObjects
    {
        public static void Main()
        {
            string first = "Hello";
            string second = "World";
            object word = first + " " + second;
            string third = (string)word;

            Console.WriteLine(third);
        }
    }
}
