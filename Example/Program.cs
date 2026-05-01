namespace Example;

static class Program
{
    static void Main(string[] args)
    {
        DateTime now = DateTime.Now;
        Console.WriteLine($"現在日時:{now}");
        Console.WriteLine($"曜日番号:{now.DayOfWeek}");
        Console.WriteLine($"年月日:{now.Year}/{now.Month}/{now.Day}");
        Console.WriteLine($"now.ToLongDateString():{now.ToLongDateString()}");
        Console.WriteLine($"now.ToLongTimeString():{now.ToLongTimeString()}");
        Console.WriteLine($"now.ToShortDateString():{now.ToShortDateString()}");
        Console.WriteLine($"now.ToShortTimeString():{now.ToShortTimeString()}");
        DateTime after = now.AddDays(40);
        Console.WriteLine($"after.ToShortDateString():{after.ToShortDateString()}");
    }
}
