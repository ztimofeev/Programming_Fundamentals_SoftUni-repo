namespace Print_Part_Of_ASCII_Table
{
    using System;

    public class PrintPartOfASCIITable
    {
        public static void Main()
        {
            var startNum = int.Parse(Console.ReadLine());
            var endNum = int.Parse(Console.ReadLine());

            for (int i = startNum; i <= endNum; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
