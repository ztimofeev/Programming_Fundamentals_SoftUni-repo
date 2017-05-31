namespace Elevator
{
    using System;

    public class Elevator
    {
        public static void Main()
        {
            var persons = int.Parse(Console.ReadLine());
            var elevatorCapacity = int.Parse(Console.ReadLine());

            int countCourses = (int)Math.Ceiling((double)persons / elevatorCapacity);

            Console.WriteLine(countCourses);
        }
    }
}
