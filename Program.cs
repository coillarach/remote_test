using System;

class Program
{
    static void DisplayDate()
    {
        string date = DateTime.Now.ToString("yyyy-MM-dd"); // Format: YYYY-MM-DD
        Console.WriteLine($"Today's date is {date}");
    }
}
