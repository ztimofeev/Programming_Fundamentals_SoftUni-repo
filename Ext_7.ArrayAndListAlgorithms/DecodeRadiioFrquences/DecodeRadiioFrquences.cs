namespace DecodeRadioFrequencies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DecodeRadioFrequencies
    {
        public static void Main()
        {
            var radioFreq = Console.ReadLine().Split(new char[] { ' ', '.' }).Select(int.Parse).ToArray();

            List<char> leftPart = new List<char>();
            List<char> rightPart = new List<char>();

            for (int i = 0; i < radioFreq.Length; i++)
            {
                if (i % 2 == 0 && radioFreq[i] != 0)
                {
                    leftPart.Add((char)radioFreq[i]);
                }
                else if (i % 2 != 0 && radioFreq[i] != 0)
                {
                    rightPart.Add((char)radioFreq[i]);
                }
            }

            rightPart.Reverse();
            var result = leftPart.Concat(rightPart);

            Console.WriteLine(string.Join("", result));
        }
    }
}
