using System;

class Program
{
    static void DisplayDate()
    {
        string date = DateTime.Now.ToString("D");
        Console.WriteLine($"Today's date is {date}");
    }
}
