namespace Ex_02_08;

static class Program
{
    static void Main(string[] args)
    {
        string[] inputStation = { "品川", "大崎", "五反田", "目黒", "恵比寿", "渋谷", "原宿", "代々木", "新宿" };

        for (int i = 0; i < inputStation.Length; i++)
        {
            Console.WriteLine($"{inputStation[i]}");
        }
    }
}
