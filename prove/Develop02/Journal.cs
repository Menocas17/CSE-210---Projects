using System.IO;
using System.Security.Cryptography.X509Certificates;

public class Journal 
{
    public List<Entry> _entries = new List<Entry>();


    public void AddEntry ()
    {
        Entry newEntry = new Entry ();
        newEntry.Display();
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach(var entry in _entries)
        {
            Console.WriteLine($"Date: {entry._date} - Prompt: {entry._propmText}");
            Console.WriteLine($"{entry._entryText}\n");
    
        }
    }

    public void SaveToFile (string fileName)
    {

         if (!fileName.EndsWith(".csv"))
        {
            fileName += ".csv";
        }

        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string journalsFolderPath = Path.Combine(desktopPath, "Journals");


        if (!Directory.Exists(journalsFolderPath))
        {
            Directory.CreateDirectory(journalsFolderPath);
        }

        string fullPath = Path.Combine(journalsFolderPath, fileName);

        using (StreamWriter outputFile = new StreamWriter(fullPath))
        {
             foreach (var entry in _entries)
            {
             
                string escapedEntryText = entry._entryText.Replace("\"", "\"\"");

                string formattedEntryText = $"\"{escapedEntryText}\"";

                outputFile.WriteLine($"{entry._date},{entry._propmText}, {formattedEntryText}");
            }
        }
    }

    public void LoadFromFile(string fileName)
    {
        _entries.Clear();

        if (!fileName.EndsWith(".csv"))
        {
            fileName += ".csv";
        }


        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        string journalsFolderPath = Path.Combine(desktopPath, "Journals");

        string fullPath = Path.Combine(journalsFolderPath, fileName);

        if (!File.Exists(fullPath))
        {
            Console.WriteLine("The file does not exists");
            return;
        }

        

        using (StreamReader inputFile = new StreamReader(fullPath))
        {
            string line;
            while ((line = inputFile.ReadLine()) != null)
            {
                string [] parts = line.Split(",");
                if (parts.Length >= 3)
                {
                    string date = parts[0];
                    string promptText = parts[1];
                    string entryText = parts [2];
                    Entry entry = new Entry {_date = date, _propmText = promptText, _entryText = entryText};
                    _entries.Add(entry);

                }

            }
        }
    }

}