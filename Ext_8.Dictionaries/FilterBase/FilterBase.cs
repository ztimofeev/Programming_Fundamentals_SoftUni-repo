namespace FilterBase
{
    using System;
    using System.Collections.Generic;

    public class FilterBase
    {
        public static void Main()
        {
            var employeesAge = new Dictionary<string, int>();
            var employeesSalary = new Dictionary<string, double>();
            var employeesPositin = new Dictionary<string, string>();

            var line = Console.ReadLine();

            while (line != "filter base")
            {
                var tokens = line.Split();
                var name = tokens[0];
                var secondData = tokens[tokens.Length - 1];

                int age;
                double salary;
                if (int.TryParse(secondData, out age))
                {
                    employeesAge[name] = age;
                }
                else if (double.TryParse(secondData, out salary))
                {
                    employeesSalary[name] = Math.Round(salary, 2);
                }
                else
                {
                    employeesPositin[name] = secondData;
                }

                line = Console.ReadLine();
            }

            line = Console.ReadLine();
            switch (line)
            {
                case "Age":
                    foreach (var kvp in employeesAge)
                    {
                        Console.WriteLine($"Name: {kvp.Key}");
                        Console.WriteLine($"Age: {kvp.Value}");
                        Console.WriteLine(new string('=', 20));
                    }
                    break;
                case "Salary":
                    foreach (var kvp in employeesSalary)
                    {
                        Console.WriteLine($"Name: {kvp.Key}");
                        Console.WriteLine($"Salary: {kvp.Value}");
                        Console.WriteLine(new string('=', 20));
                    }
                    break;
                case "Position":
                    foreach (var kvp in employeesPositin)
                    {
                        Console.WriteLine($"Name: {kvp.Key}");
                        Console.WriteLine($"Position: {kvp.Value}");
                        Console.WriteLine(new string('=', 20));
                    }
                    break;
            }
        }
    }
}