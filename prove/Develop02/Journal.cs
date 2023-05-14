class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string fileName)
    {
        Console.WriteLine("Saving to file...");
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine(entry.ToString());
            }
        }
    }

    public void LoadFromFile(string fileName)
    {
        Console.WriteLine("Loading list from file...");
        List<Entry> loadedEntries = new List<Entry>();
        string[] lines = File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("//");

            string prompt = parts[0];
            string answer = parts[1];
            DateTime date = DateTime.Parse(parts[2]);

            Entry entry = new Entry(prompt, answer, date);
            loadedEntries.Add(entry);
        }

        entries = loadedEntries;
    }
}
