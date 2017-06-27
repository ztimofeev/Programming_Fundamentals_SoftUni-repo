using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsGrades
{
    public class StudentdGrades
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> studentsGrades = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                var studentInfo = Console.ReadLine().Split();
                var name = studentInfo[0];
                var grade = decimal.Parse(studentInfo[1]);

                if (!studentsGrades.ContainsKey(name))
                {
                    studentsGrades[name] = new List<decimal>();
                }

                studentsGrades[name].Add(grade);
            }

            foreach (var pairs in studentsGrades)
            {
                Console.WriteLine("{0} -> {1} (avg: {2})", pairs.Key, string.Join(" ", pairs.Value), pairs.Value.Average());
            }
        }
    }
}
