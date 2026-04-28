using System.Net.ServerSentEvents;

namespace Ex_03_01;

static class Program
{
    static void Main(string[] args)
    {
        // インスタンスの生成
        Item item = new Item();
        // フィールドに値を設定する
        Console.Write("商品番号を入力してください -> ");
        item.itemNo = int.Parse(Console.ReadLine());
        Console.Write("商品名を入力してください -> ");
        item.itemName = Console.ReadLine();
        Console.Write("単価を入力してください -> ");
        item.price = int.Parse(Console.ReadLine());
        // フィールドの値を取得する
        Console.WriteLine("結果");
        Console.WriteLine($"商品番号 = {item.itemNo}");
        Console.WriteLine($"商品名 = {item.itemName}");
        Console.WriteLine($"単価 = {item.price}");
    }
}
