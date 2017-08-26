using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class Exercises
    {
        public class Exercise
        {
            public string Topic { get; set; }
            public string CourseName { get; set; }
            public string JudgeContestLink { get; set; }
            public List<string> Problems { get; set; }
        }

        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var exercises = new List<Exercise>();

            while (inputLine != "go go go")
            {
                var inputTokens = inputLine.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var topic = inputTokens[0];
                var course = inputTokens[1];
                var judgeLink = inputTokens[2];
                var themes = inputTokens[3].Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                var problemsList = new List<string>();

                for (int i = 0; i < themes.Length; i++)
                {
                    problemsList.Add(themes[i]);
                }

                var ex = new Exercise
                {
                    Topic = topic,
                    CourseName = course,
                    JudgeContestLink = judgeLink,
                    Problems = problemsList
                };

                exercises.Add(ex);

                inputLine = Console.ReadLine();
            }

            foreach (Exercise exercise in exercises)
            {
                Console.WriteLine("Exercises: {0}", exercise.Topic);
                Console.WriteLine("Problems for exercises and homework for the \"{0}\" course @ SoftUni.", exercise.CourseName);
                Console.WriteLine("Check your solutions here: {0}", exercise.JudgeContestLink);

                var problems = exercise.Problems;
                var counter = 1;
                foreach (var problem in problems)
                {
                    Console.WriteLine("{0}. {1}", counter, problem);
                    counter++;
                }
            }
        }
    }
}
