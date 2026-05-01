namespace Ex_03_09;

static class Program
{
    static void Main(string[] args)
    {
        ///コンソールへの記入
        Console.Write("口座番号を入力してください - > ");
        string AccountNo = Console.ReadLine();
        Console.Write("口座名義を入力してください - > ");
        string AccountName = Console.ReadLine();
        Console.Write("残高を入力してください - > ");
        int Balance = int.Parse(Console.ReadLine());
        Console.Write("ポイントを入力してください - > ");
        int Point = int.Parse(Console.ReadLine());
        ///コンストラクタ呼び出し（親クラスの変数に子クラスのインスタンスの参照を代入）
        Account netaccount = new NetAccount(AccountNo, AccountName, Balance, Point);
        ///結果の表示
        Console.WriteLine("結果");
        netaccount.Print();
        Console.WriteLine(netaccount.ToString());
    }
}
