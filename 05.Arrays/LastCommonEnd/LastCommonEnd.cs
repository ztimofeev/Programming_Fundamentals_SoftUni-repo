namespace LastCommonEnd
{
    using System;
    using System.Linq;
    public class LastCommonEnd
    {
        public static void Main()
        {
            var seq1 = Console.ReadLine().Split().ToArray();
            var seq2 = Console.ReadLine().Split().ToArray();

            var shortestLength = seq2.Length;
            var result = 0;

            if (seq1.Length <= seq2.Length)
            {
                shortestLength = seq1.Length;
            }

            if (seq1[0] == seq2[0])
            {
                result = GetLargestCommonEnd(seq1, seq2, shortestLength);
            }
            else if (seq1[seq1.Length - 1] == seq2[seq2.Length - 1])
            {
                var reversedSeq1 = seq1.Reverse().ToArray();
                var reversedSeq2 = seq2.Reverse().ToArray();
                result = GetLargestCommonEnd(reversedSeq1, reversedSeq2, shortestLength);
            }

            Console.WriteLine(result);
        }

        public static int GetLargestCommonEnd(string[] a, string[] b, int length)
        {
            var counter = 0;

            for (int i = 0; i < length; i++)
            {
                if (a[i] == b[i])
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
