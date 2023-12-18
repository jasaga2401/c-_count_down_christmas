using System;

class Program
{
    static void Main()
    {
        DateTime currentDateTime = DateTime.Now;
        DateTime christmas = new DateTime(currentDateTime.Year, 12, 25);

        // If it's already Christmas or past Christmas this year, set to next year's Christmas
        if (currentDateTime >= christmas)
        {
            christmas = new DateTime(currentDateTime.Year + 1, 12, 25);
        }

        TimeSpan timeRemaining = christmas - currentDateTime;

        Console.WriteLine($"Time remaining until Christmas: {timeRemaining.Days} days, {timeRemaining.Hours} " +
            $"hours, {timeRemaining.Minutes} minutes, and {timeRemaining.Seconds} seconds.");

        Console.ReadLine(); // Keeps the console window open
    }
}
