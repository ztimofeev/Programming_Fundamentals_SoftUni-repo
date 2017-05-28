namespace BPM_Counter
{
    using System;

    public class BPM_Counter
    {
        public static void Main()
        {
            var bpm = int.Parse(Console.ReadLine());
            var beats = int.Parse(Console.ReadLine());

            var bars = Math.Round(beats / 4.0, 1);

            var sequenceDuration = Math.Floor(60.0 / bpm * beats);
            var minutes = (int)sequenceDuration / 60;
            var secundes = (int)sequenceDuration % 60;

            Console.WriteLine($"{bars} bars - {minutes}m {secundes}s");
        }
    }
}
