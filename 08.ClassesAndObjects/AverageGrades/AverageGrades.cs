namespace AverageGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AverageGrades
    {
        public class Student
        {
            public string Name { get; set; }

            public List<double> Grades { get; set; }

            public double AverageGrade
            {
                get
                {
                    return (double)Grades.Average();
                }
            }
        }

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            List<Student> studentsByGrades = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                var inputData = Console.ReadLine().Split();

                List<double> studentGrades = new List<double>();

                for (int j = 1; j < inputData.Length; j++)
                {
                    studentGrades.Add(double.Parse(inputData[j]));
                }

                var student = new Student
                {
                    Name = inputData[0],
                    Grades = studentGrades
                };

                studentsByGrades.Add(student);
            }

            var lastList = studentsByGrades.Where(x => x.AverageGrade >= 5.00).OrderBy(w => w.Name).ThenByDescending(g => g.AverageGrade);

            foreach (var student in lastList)
            {
                Console.WriteLine("{0:F2} -> {1:F2}", student.Name, student.AverageGrade);
            }
        }
    }
}
