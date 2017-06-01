namespace Different_Integers_Size
{
    using System;
    using System.Numerics;

    public class DifferentIntegersSize
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            BigInteger number;
            if (BigInteger.TryParse(input, out number))
            {
                if (number < 0)
                {
                    if (number >= -128)
                    {
                        Console.WriteLine("{0} can fit in:", number);
                        Console.WriteLine("* sbyte");
                        Console.WriteLine("* short");
                        Console.WriteLine("* int");
                        Console.WriteLine("* long");
                    }
                    else if (number < 128 && number >= -32768)
                    {
                        Console.WriteLine("{0} can fit in:", number);
                        Console.WriteLine("* short");
                        Console.WriteLine("* int");
                        Console.WriteLine("* long");
                    }
                    else if (number < -32768 && number >= -2147483648)
                    {
                        Console.WriteLine("{0} can fit in:", number);
                        Console.WriteLine("* int");
                        Console.WriteLine("* long");
                    }
                    else if (number < -2147483648 && number >= -9223372036854775808)
                    {
                        Console.WriteLine("{0} can fit in:", number);
                        Console.WriteLine("* long");
                    }
                }
                else if (number >= 0)
                {
                    if (number <= 127)
                    {
                        Console.WriteLine("{0} can fit in:", number);
                        Console.WriteLine("* sbyte");
                        Console.WriteLine("* byte");
                        Console.WriteLine("* short");
                        Console.WriteLine("* ushort");
                        Console.WriteLine("* int");
                        Console.WriteLine("* uint");
                        Console.WriteLine("* long");
                    }
                    else if (number > 127 && number <= 255)
                    {
                        Console.WriteLine("{0} can fit in:", number);
                        Console.WriteLine("* byte");
                        Console.WriteLine("* short");
                        Console.WriteLine("* ushort");
                        Console.WriteLine("* int");
                        Console.WriteLine("* uint");
                        Console.WriteLine("* long");
                    }
                    else if (number > 255 && number <= 32767)
                    {
                        Console.WriteLine("{0} can fit in:", number);
                        Console.WriteLine("* short");
                        Console.WriteLine("* ushort");
                        Console.WriteLine("* int");
                        Console.WriteLine("* uint");
                        Console.WriteLine("* long");
                    }
                    else if (number > 32767 && number <= 65535)
                    {
                        Console.WriteLine("{0} can fit in:", number);
                        Console.WriteLine("* ushort");
                        Console.WriteLine("* int");
                        Console.WriteLine("* uint");
                        Console.WriteLine("* long");
                    }
                    else if (number > 65535 && number <= 2147483647)
                    {
                        Console.WriteLine("{0} can fit in:", number);
                        Console.WriteLine("* int");
                        Console.WriteLine("* uint");
                        Console.WriteLine("* long");
                    }
                    else if (number > 2147483647 && number <= 4294967295)
                    {
                        Console.WriteLine("{0} can fit in:", number);
                        Console.WriteLine("* uint");
                        Console.WriteLine("* long");
                    }
                    else if (number > 4294967295 && number <= 9223372036854775807)
                    {
                        Console.WriteLine("{0} can fit in:", number);
                        Console.WriteLine("* long");
                    }
                }

                if (number < -9223372036854775808 || number > 9223372036854775807)
                {
                    Console.WriteLine("{0} can't fit in any type", number);
                }
            }
        }
    }
}
