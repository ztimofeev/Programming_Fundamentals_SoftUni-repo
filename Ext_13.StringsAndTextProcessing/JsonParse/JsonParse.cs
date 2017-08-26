using System;
using System.Collections.Generic;
using System.Linq;

namespace JsonParse
{
    public class JsonParse
    {
        class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public List<int> Grades { get; set; }
        }

        public static void Main()
        {
            var inputLine = Console.ReadLine().Trim().Trim('[').Trim(']').Split('{', '}');

            List<Student> students = new List<Student>();

            foreach (var tokens in inputLine)
            {
                if (tokens != "," && tokens != String.Empty)
                {
                    var studentData =
                        tokens.Replace("name:", "")
                            .Replace("age:", "")
                            .Replace("grades:", "")
                            .Replace("[", "")
                            .Replace("]", "")
                            .Replace("\"", "")
                            .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .ToArray();

                    var studentName = studentData[0];
                    var studentAge = int.Parse(studentData[1]);

                    List<int> studentGrades = 
                        studentData
                            .Skip(2)
                            .Select(int.Parse)
                            .ToList();

                    Student currentStudent = new Student();

                    currentStudent.Name = studentName;
                    currentStudent.Age = studentAge;
                    currentStudent.Grades = studentGrades;

                    students.Add(currentStudent);
                }
            }

            foreach (var student in students)
            {
                var grades = string.Join(", ", student.Grades);

                if (grades != String.Empty)
                {
                    Console.WriteLine($"{student.Name} : {student.Age} -> {grades}");
                }
                else
                {
                    Console.WriteLine($"{student.Name} : {student.Age} -> None");
                }
            }
        }
    }
}