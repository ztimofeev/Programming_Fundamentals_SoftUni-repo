namespace Instruction_Set
{
    using System.Linq;
    using System.Numerics;

    using System;

    public class InstructionSet
    {
        static void Main()
        {
            var line = Console.ReadLine().Split().ToArray();

            BigInteger result = 0;

            while (line[0] != "END")
            {
                switch (line[0])
                {
                    case "INC":
                    {
                        long operandOne = long.Parse(line[1]);
                        result = operandOne + 1;
                        break;
                    }
                    case "DEC":
                    {
                        long operandOne = long.Parse(line[1]);
                        result = operandOne - 1;
                        break;
                    }
                    case "ADD":
                    {
                        long operandOne = long.Parse(line[1]);
                        long operandTwo = long.Parse(line[2]);
                        result = operandOne + operandTwo;
                        break;
                    }
                    case "MLA":
                    {
                        long operandOne = long.Parse(line[1]);
                        long operandTwo = long.Parse(line[2]);
                        result = operandOne * operandTwo;
                        break;
                    }
                }

                Console.WriteLine(result);

                line = Console.ReadLine().Split().ToArray();
            }
        }
    }
}
