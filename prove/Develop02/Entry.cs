using System;

public class Entry
{
    public string _prompt;
    public string _userResponse;
    public string _date;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} ");
        Console.WriteLine($"Prompt: {_prompt} ");
        Console.WriteLine($"Entry: {_userResponse} ")
    }
}