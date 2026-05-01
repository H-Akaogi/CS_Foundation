namespace Ex_03_09;

static class Program
{
    static void Main(string[] args)
    {
        ///コンソールへの記入
        Console.Write("口座番号を入力してください - > ");
        string? AccountNo = Console.ReadLine(); //nullableの変数にする（?を型名のうしろにつける）
        Console.Write("口座名義を入力してください - > ");
        string? AccountName = Console.ReadLine();
        Console.Write("残高を入力してください - > ");
        int Balance = int.Parse(Console.ReadLine()!);//int型の場合は?つけられない。!を付ける
        Console.Write("ポイントを入力してください - > ");
        int Point = int.Parse(Console.ReadLine()!);
        ///コンストラクタ呼び出し（型名 変数 = new コンストラクタ(引数)）
        var netaccount = new NetAccount(AccountNo!, AccountName!, Balance, Point);
        ///結果の表示
        Console.WriteLine("結果");
        netaccount.Print();
        Console.WriteLine(netaccount.ToString());
    }
}
