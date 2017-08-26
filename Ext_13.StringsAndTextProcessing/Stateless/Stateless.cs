namespace Stateless
{
    using System;

    class Stateless
    {
        public static void Main()
        {
            string input = Console.ReadLine().Trim();

            while (input != "collapse")
            {
                string fiction = Console.ReadLine();

                string collapsedInput = StringCollapsing(input, fiction);

                if (collapsedInput.Length > 0)
                {
                    Console.WriteLine(collapsedInput);
                }
                else
                {
                    Console.WriteLine("(void)");
                }

                input = Console.ReadLine();
            }
        }

        public static string StringCollapsing(string input, string fiction)
        {
            while (fiction.Length > 0)
            {
                if (input.Contains(fiction))
                {
                    input = input.Replace(fiction, "").Trim();
                }

                if (fiction.Length == 1)
                {
                    fiction = fiction.Remove(0, 1);
                }
                else
                {
                    fiction = fiction.Remove(0, 1);
                    fiction = fiction.Remove(fiction.Length - 1, 1);
                }
            }

            return input;
        }
    }
}
