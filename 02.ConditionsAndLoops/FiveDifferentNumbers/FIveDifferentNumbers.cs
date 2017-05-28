namespace FiveDifferentNumbers
{
    using System;

    public class FIveDifferentNumbers
    {
        public static void Main()
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());


            if (secondNumber - firstNumber >= 4)
            {
                for (int n1 = firstNumber; n1 <= secondNumber; n1++)
                {
                    for (int n2 = n1 + 1; n2 <= secondNumber; n2++)
                    {
                        for (int n3 = n2 + 1; n3 <= secondNumber; n3++)
                        {
                            for (int n4 = n3 + 1; n4 <= secondNumber; n4++)
                            {
                                for (int n5 = n4 + 1; n5 <= secondNumber; n5++)
                                {
                                    if (n1 < n2 && n2 < n3 && n3 < n4 && n4 < n5)
                                    {
                                        Console.WriteLine($"{n1} {n2} {n3} {n4} {n5}");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
