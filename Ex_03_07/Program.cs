using Ex_03_07_Item.Models;
namespace Ex_03_07;

static class Program
{
    static void Main(string[] args)
    {
        ///型数・変数名を設定
        Item item01 = new Item(); //コンストラクタ呼び出し
        Console.Write("商品番号を入力してください -> ");
        item01.ItemNo = int.Parse(Console.ReadLine()); //ドットの前にインスタンスを付けて呼び出す
        Console.Write("商品名を入力してください -> ");
        item01.ItemName = Console.ReadLine();         //Console.Readは一文字のみ読み取る。
        Console.Write("単価を入力してください -> ");
        item01.Price = int.Parse(Console.ReadLine());

        Console.WriteLine("結果");

        item01.Print();
    }
}