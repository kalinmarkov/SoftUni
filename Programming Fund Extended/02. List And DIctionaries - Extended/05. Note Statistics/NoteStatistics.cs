using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NoteStatistics
{
    static void Main()
    {
        var inputFrequencies = Console.ReadLine().Split().Select(double.Parse).ToList();

        var frequencies = "261.63 277.18 293.66 311.13 329.63 349.23 369.99 392.00 415.30 440.00 466.16 493.88"
            .Split()
            .Select(double.Parse)
            .ToList();

        var notes = "C C# D D# E F F# G G# A A# B".Split().ToList();

        var resultNotes = new List<string>();

        foreach (var frequency in inputFrequencies)
        {
            var frequencyIndex = frequencies.IndexOf(frequency);
            var note = notes[frequencyIndex];

            resultNotes.Add(note);
        }

        Console.WriteLine("Notes: {0}", string.Join(" ", resultNotes));

        var naturals = new List<string>();
        var sharps = new List<string>();

        foreach (var note in resultNotes)
        {
            if (note.Contains('#'))
            {
                sharps.Add(note);
            }
            else
            {
                naturals.Add(note);
            }
        }

        Console.WriteLine("Naturals: {0}", string.Join(", ", naturals));
        Console.WriteLine("Sharps: {0}", string.Join(", ", sharps));

        var naturalsSum = GetNoteSum(frequencies, notes, naturals);
        var sharpsSum = GetNoteSum(frequencies, notes, sharps);

        Console.WriteLine("Naturals sum: {0}", string.Join(", ", naturalsSum));
        Console.WriteLine("Sharps sum: {0}", string.Join(", ", sharpsSum));
    }

    private static double GetNoteSum(List<double> frequencies, List<string> allNotes, List<string> notes)
    {
        var noteSum = 0d;
        foreach (var note in notes)
        {
            var frequencyIndex = allNotes.IndexOf(note);
            var frequency = frequencies[frequencyIndex];
            noteSum += frequency;
        }

        return noteSum;
    }
}

