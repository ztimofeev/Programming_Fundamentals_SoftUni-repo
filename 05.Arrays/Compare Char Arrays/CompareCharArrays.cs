namespace Compare_Char_Arrays
{
    using System;
    using System.Linq;

    public class CompareCharArrays
    {
        public static void Main()
        {
            var arr1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            var arr2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            if (arr1.Length < arr2.Length)
            {
                PrintArray(arr1);
                PrintArray(arr2);
            }
            else if (arr1.Length > arr2.Length)
            {
                PrintArray(arr2);
                PrintArray(arr1);
            }
            else
            {
                var len = arr1.Length;
                bool result = true;
                for (int i = 0; i < len; i++)
                {
                    if (arr1[i] > arr2[i])
                    {
                        result = false;
                        break;
                    }
                }

                if (result)
                {
                    PrintArray(arr1);
                    PrintArray(arr2);
                }
                else
                {
                    PrintArray(arr2);
                    PrintArray(arr1);
                }
            }
        }

        public static void PrintArray(char[] arr)
        {
            Console.WriteLine(string.Join("", arr));
        }
    }
}
