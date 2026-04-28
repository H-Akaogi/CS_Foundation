namespace Ex_02_08;

static class Program
{
    static void Main(string[] args)
    {
        string[] inputStation = { "品川", "大崎", "五反田", "目黒", "恵比寿", "渋谷", "原宿", "代々木", "新宿" };

        var i = 1;
        while (i < inputStation.Length)
        {
            Console.WriteLine($"{inputStation[i]}");
            i++;
        }
    }
}
