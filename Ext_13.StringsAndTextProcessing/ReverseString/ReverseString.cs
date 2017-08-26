namespace ReverseString
{
    using System;
    using System.Linq;

    public class ReverseString
    {
        public static void Main()
        {
            char[] text = Console.ReadLine().ToCharArray();

            string result = new string(text.Reverse().ToArray());
            
            Console.WriteLine(result);
        }
    }
}
