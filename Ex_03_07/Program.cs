using Ex_03_07_Item.Models;
namespace Ex_03_07;

static class Program
{
    static void Main(string[] args)
    {
        ///型数・変数名を設定
        ///フィールドは小文字、プロパティは大文字
        Item item = new Item(); //コンストラクタ呼び出し
        Console.Write("商品番号を入力してください -> ");
        item.ItemNo = int.Parse(Console.ReadLine()); //ドットの前にインスタンスを付けて呼び出す
        Console.Write("商品名を入力してください -> ");
        item.ItemName = Console.ReadLine();         //Console.Readは一文字のみ読み取る。
        Console.Write("単価を入力してください -> ");
        item.Price = int.Parse(Console.ReadLine());

        Console.WriteLine("結果");

        item.Print();
    }
}