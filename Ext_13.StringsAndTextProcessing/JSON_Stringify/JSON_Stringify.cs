using System.Linq;

namespace Json_Stringify
{
    using System;
    using System.Collections.Generic;

    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<int> Grades { get; set; }
    }

    public class Json_Stringify
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            List<Student> students = new List<Student>();

            while (inputLine != "stringify")
            {
                string[] inputTokens = inputLine.Split(new []{' ', ':', '-', '>', ','}, StringSplitOptions.RemoveEmptyEntries);
                var studentName = inputTokens[0];
                var studentAge = int.Parse(inputTokens[1]);
                var studentGrades = inputTokens.Skip(2).Select(int.Parse).ToList();

                Student currentStudent = new Student();

                currentStudent.Name = studentName;
                currentStudent.Age = studentAge;
                currentStudent.Grades = studentGrades;

                students.Add(currentStudent);

                inputLine = Console.ReadLine();
            }

            List<string> studentsToPrint = new List<string>();
            
            foreach (var student in students)
            {
                if (student.Grades != null)
                {
                    studentsToPrint.Add('{' + $"name:\"{student.Name}\",age:{student.Age},grades:[{string.Join(", ", student.Grades)}]" + '}');
                }
                else
                {
                    studentsToPrint.Add('{' + $"name:\"{student.Name}\",age:{student.Age},grades:[]" + '}');
                }
            }

            Console.WriteLine('[' + string.Join(",", studentsToPrint) + ']');
        }
    }
}