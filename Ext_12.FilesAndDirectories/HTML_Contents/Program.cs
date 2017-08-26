namespace HTML_Contents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            List<string[]> tagsAndContents = new List<string[]>();
            string title = string.Empty;
            var path = "index.html";

            while (inputLine != "exit")
            {
                var tokens = inputLine
                    .Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(t => t.Trim())
                    .ToArray();

                if (tokens[0] == "title")
                {
                    title = tokens[1];  
                }
                else
                {
                    tagsAndContents.Add(tokens);
                }

                inputLine = Console.ReadLine();
            }

            File.WriteAllText(path, "<!DOCTYPE html>" + Environment.NewLine);
            File.AppendAllText(path, "<html>" + Environment.NewLine);
            File.AppendAllText(path, "<head>" + Environment.NewLine);
            File.AppendAllText(path, $"\t<title>{title}</title>" + Environment.NewLine);
            File.AppendAllText(path, "</head>" + Environment.NewLine);

            File.AppendAllText(path, "<body>" + Environment.NewLine);

            foreach (var token in tagsAndContents)
            {
                File.AppendAllText(path, $"\t<{token[0]}>{token[1]}</{token[0]}>" + Environment.NewLine);
            }

            File.AppendAllText(path, "</body>" + Environment.NewLine);
            File.AppendAllText(path, "</html>" + Environment.NewLine);
        }
    }
}
