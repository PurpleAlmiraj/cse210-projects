using System;
using System.Collections.Generic;

public class Journal
{
    private List<DailyEntry> entries;

    public Journal()
    {
        entries = new List<DailyEntry>();
    }

    public void AddEntry(DailyEntry entry)
    {
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string filename)
    {
    using (var writer = new StreamWriter(filename))
    {
        foreach (var entry in entries)
        {
            writer.WriteLine($"Date: {entry._date} Prompt: {entry._prompt} Entry: {entry._entry}");
        }
    }
    }
}