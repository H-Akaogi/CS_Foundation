namespace Ex_02_11;

static class Program
{
    static void Main(string[] args)
    {
        string[] inputStation = { "品川", "大崎", "五反田", "目黒", "恵比寿", "渋谷", "原宿", "代々木", "新宿" };//配列の登録

        Console.Write("駅名を入力してください -> ");
        var notinclude = Console.ReadLine();//入力名をnotincludeとして登録
        for (int i = 0; i < inputStation.Length; i++)
        {
            if (notinclude == inputStation[i]) //notincludeのときのみ処理
            {
                continue;//スキップ
            }
            Console.WriteLine($"{inputStation[i]}");
        }
    }
}
