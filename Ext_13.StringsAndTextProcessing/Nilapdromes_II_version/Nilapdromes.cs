namespace Nilapdromes
{
    using System;

    public class Nilapdromes
    {
        public static void Main()
        {
            string line = Console.ReadLine();

            while (line != "end")
            {
                string nilap = FindNilap(line);

                if (nilap != "")
                {
                    Console.WriteLine(nilap);
                }

                line = Console.ReadLine();
            }
        }

        public static string FindNilap(string str)
        {
            string nilap = "";
            string border = "";

            string leftSubStr = "";
            string rightSubStr = "";

            for (int i = 0; i < str.Length / 2; i++)
            {
                leftSubStr += str[i];
                rightSubStr = rightSubStr.Insert(0, str[str.Length - 1 - i] + "");

                if (leftSubStr == rightSubStr)
                {
                    border = leftSubStr;
                }
            }

            if (border != "")
            {
                int firstIndexOfBorder = str.IndexOf(border);
                string content = str.Remove(firstIndexOfBorder, border.Length);
                
                int lastIndexOfBorder = content.LastIndexOf(border);
                content = content.Remove(lastIndexOfBorder);
                
                if (content != "")
                {
                    return content + border + content;
                }
            }

            return String.Empty;
        }
    }
}
