using System;
using System.Collections.Generic;

namespace StringCommander
{
    class StringCommander
    {
        public static void Main()
        {
            var inputText = Console.ReadLine();
            var commandLine = Console.ReadLine();

            while (commandLine != "end")
            {
                var tokens = commandLine.Split();
                var command = tokens[0].ToLower();

                switch (command)
                {
                    case "left":
                        var countPositionsLeft = int.Parse(tokens[1]);
                        inputText = LeftMovement(inputText, countPositionsLeft);
                        break;

                    case "right":
                        var countPositionsRight = int.Parse(tokens[1]);
                        inputText = RightMovement(inputText, countPositionsRight);
                        break;

                    case "delete":
                        var startIndex = int.Parse(tokens[1]);
                        var endIndex = int.Parse(tokens[2]);
                        inputText = DeleteText(inputText, startIndex, endIndex);
                        break;

                    case "insert":
                        var insertIndex = int.Parse(tokens[1]);
                        var textToInsert = tokens[2];
                        inputText = InsertionText(inputText, insertIndex, textToInsert);
                        break;
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine(inputText);
        }

        public static string LeftMovement(string txt, int positions)
        {
            var input = txt.ToCharArray();

            char[] charArray = new char[input.Length];

            for (int i = 0; i < positions; i++)
            {
                char temp = input[0];
                for (int j = 1; j < input.Length; j++)
                {
                    charArray[j - 1] = input[j];
                }

                charArray[charArray.Length - 1] = temp;
                input = charArray;

                if (i != 1)
                {
                    charArray = new char[input.Length];
                }
            }

            return string.Join("", input);
        }

        public static string RightMovement(string txt, int positions)
        {
            var input = txt.ToCharArray();

            char[] charArray = new char[input.Length];

            for (int i = 0; i < positions; i++)
            {
                char temp = input[input.Length - 1];
                for (int j = input.Length - 1; j > 0; j--)
                {
                    charArray[j] = input[j - 1];
                }

                charArray[0] = temp;
                input = charArray;

                if (i != 1)
                {
                    charArray = new char[input.Length];
                }
            }

            return string.Join("", input);
        }

        public static string DeleteText(string txt, int startIndex, int endIndex)
        {
            var delLenght = endIndex - startIndex;

            return txt.Remove(startIndex, delLenght + 1);
        }

        public static string InsertionText(string txt, int startIndex, string textIn)
        {
            var input = txt.ToCharArray();
            List<char> charList = new List<char>();
            char[] charsToInsert = new char[textIn.Length];

            foreach (char ch in input)
            {
                charList.Add(ch);
            }

            for (int i = 0; i < textIn.Length; i++)
            {
                charsToInsert[i] = textIn[i];
            }

            charList.InsertRange(startIndex, charsToInsert);

            return string.Join("", charList);
        }
    }
}
