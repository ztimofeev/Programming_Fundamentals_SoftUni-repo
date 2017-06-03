namespace Decrypting_Messages
{
    using System;

    public class DecryptingMessages
    {
        public static void Main()
        {
            var decryptingKey = byte.Parse(Console.ReadLine());
            var iterations = byte.Parse(Console.ReadLine());

            string message = string.Empty;

            for (int i = 0; i < iterations; i++)
            {
                var currentLetter = char.Parse(Console.ReadLine());
                message += (char)(currentLetter + decryptingKey);
            }

            Console.WriteLine(message);
        }
    }
}
