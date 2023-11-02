using System;

public class Journal
{
    public List<Entries> _entry = new List<Entries>();

    public string AddEntry()
    {

    }

    public void Display()
    {
        Console.WriteLine($"Name: {_name} ");
        Console.WriteLine("Jobs: ");

        foreach (Entries entries in _entry)
        {
            entries.Display();
        }
    }
}