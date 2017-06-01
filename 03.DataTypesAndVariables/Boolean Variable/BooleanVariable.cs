namespace Boolean_Variable
{
    using System;

    public class BooleanVariable
    {
        public static void Main()
        {
            bool token = Convert.ToBoolean(Console.ReadLine());

            if (token)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
