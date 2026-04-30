namespace Ex_03_09;

static class Program
{
    static void Main(string[] args)
    {


        Console.Write("口座番号を入力してください - > ");
        netaccount.AccountNo = Console.ReadLine();
        Console.Write("口座名義を入力してください - > ");
        netaccount.AccountName = Console.ReadLine();
        Console.Write("残高を入力してください - > ");
        netaccount.Balance = int.Parse(Console.ReadLine());
        Console.Write("ポイントを入力してください - > ");
        netaccount.Point = int.Parse(Console.ReadLine());
        Account netaccount = new NetAccount(AccountNo, AccountName, Balance, Point);
        netaccount.Print();

    }

}
