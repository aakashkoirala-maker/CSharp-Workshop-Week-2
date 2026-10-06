namespace Task_5;

class Program
{
    static void Main(string[] args)
    {
        DateTime birthDate = new DateTime(2006, 5, 15);
        DateTime currentDate = DateTime.Now;

        TimeSpan difference = currentDate - birthDate;

        int age = (int)(difference.TotalDays / 365.25);

        Console.WriteLine($"Birthdate: {birthDate:yyyy-MM-dd}");
        Console.WriteLine($"Current date: {currentDate:yyyy-MM-dd HH:mm}");
        Console.WriteLine($"Age: {age} years");

        DateTime tenDaysLater = birthDate.AddDays(10);

        Console.WriteLine($"10 days after birthdate: {tenDaysLater:yyyy-MM-dd}");
    }
}