using System;

class Program
{
    static void DisplayDate()
    {
        string date = DateTime.Now.ToString("dd/MM/yyyy"); // Format: DD/MM/YYYY
        Console.WriteLine($"Today's date is {date}");
    }
}
