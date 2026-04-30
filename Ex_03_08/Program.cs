using System.Security.Principal;


namespace Ex_03_08;

static class Program
{
    static void Main(string[] args)
    {
        NetAccount netaccount = new NetAccount();
        Console.Write("口座番号を入力してください - > ");
        netaccount.AccountNo = Console.ReadLine();
        Console.Write("口座名義を入力してください - > ");
        netaccount.AccountName = Console.ReadLine();
        Console.Write("残高を入力してください - > ");
        netaccount.Balance = int.Parse(Console.ReadLine());
        Console.Write("ポイントを入力してください - > ");
        netaccount.Point = int.Parse(Console.ReadLine());
        netaccount.Print();
    }
}
