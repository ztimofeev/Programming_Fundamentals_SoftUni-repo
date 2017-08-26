namespace NoteStatistics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class NoteStatistics
    {
        public static void Main()
        {
            List<string> notes = new List<string> { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
            List<double> frequences = new List<double> { 261.63, 277.18, 293.66, 311.13, 329.63, 349.23, 369.99, 392.00, 415.30, 440.00, 466.16, 493.88 };

            var input = Console.ReadLine().Split().Select(double.Parse).ToList();

            List<string> naturalNotes = new List<string>();
            List<string> sharpedNotes = new List<string>();
            List<string> foundNotes = new List<string>();

            double naturalSum = 0;
            double sharpedSum = 0;

            for (int i = 0; i < input.Count; i++)
            {
                for (int j = 0; j < frequences.Count; j++)
                {
                    if (input[i] == frequences[j])
                    {
                        foundNotes.Add(notes[j]);

                        foreach (var item in notes[j])
                        {
                            if (item != '#' && notes[j].Length == 1)
                            {
                                naturalNotes.Add(notes[j]);
                                naturalSum += frequences[j];
                            }
                            else if (item == '#' && notes[j].Length == 2)
                            {
                                sharpedNotes.Add(notes[j]);
                                sharpedSum += frequences[j];
                            }
                        }
                    }
                }
            }

            Console.WriteLine("Notes: " + string.Join(" ", foundNotes));
            Console.WriteLine("Naturals: " + string.Join(", ", naturalNotes));
            Console.WriteLine("Sharps: " + string.Join(", ", sharpedNotes));
            Console.WriteLine($"Naturals sum: {naturalSum}");
            Console.WriteLine($"Sharps sum: { sharpedSum}");
        }
    }
}
