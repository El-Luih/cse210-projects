using System.IO;
using System.Text.RegularExpressions;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName + ".csv"))
        {
            foreach (Entry entry in _entries)
            {
                entry._entryText = entry._entryText.Replace("\"", "\"\"");
                outputFile.WriteLine($"\"{entry._date}\",\"{entry._promptText}\",\"{entry._entryText}\"");
            }
        }
    }

    public void LoadFromFile(string fileName)
    {
        _entries.Clear();
        foreach (string line in File.ReadAllLines(fileName + ".csv"))
        {
            List<string> values = new List<string>();
            foreach (Match match in Regex.Matches(line, "\"((?:[^\"]|\"\")*)\"(?:,|$)"))
            {
                string value = match.Groups[1].Value.Replace("\"\"", "\"");
                values.Add(value);
            }
            Entry entry = new Entry();
            entry._date = values[0];
            entry._promptText = values[1];
            entry._entryText = values[2];
            _entries.Add(entry);
        }
    }
}