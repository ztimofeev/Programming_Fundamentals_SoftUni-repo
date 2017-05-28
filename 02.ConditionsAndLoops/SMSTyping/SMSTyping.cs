namespace SMSTyping
{
    using System;

    public class SMSTyping
    {
        public static void Main()
        {
            var wordsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < wordsCount; i++)
            {
                var typedNumber = int.Parse(Console.ReadLine());
                var digitsLenght = GetCountOfDigits(typedNumber);
                var mainDigit = typedNumber % 10;
                var offset = 0;

                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset = (mainDigit - 2) * 3 + 1;
                }
                else
                {
                    offset = (mainDigit - 2) * 3;
                }

                var index = offset + digitsLenght - 1;
                var letter = 0;

                if (typedNumber == 0)
                {
                    letter = 32;
                }
                else
                {
                    letter = 97 + index;
                }
                
                Console.Write((char)letter);
            }
        }

        public static int GetCountOfDigits(int num)
        {
            int counter = 0;
            while (num > 0)
            {
                counter++;
                num = num / 10;
            }

            return counter;
        }
    }
}
