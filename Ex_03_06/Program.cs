namespace Ex_03_06;

static class Program
{
    static void Main(string[] args)
    {
        ///型数・変数名を設定
        Item item = new Item();
        Console.Write("商品番号を入力してください -> ");
        item.itemNo = int.Parse(Console.ReadLine()); //ドットの前にインスタンスを付けて呼び出す
        Console.Write("商品名を入力してください -> ");
        item.itemName = Console.ReadLine();         //Console.Readは一文字のみ読み取る。
        Console.Write("単価を入力してください -> ");
        item.price = int.Parse(Console.ReadLine());
        Console.Write("新しい単価を入力してください -> ");
        item.ChangePrice(int.Parse(Console.ReadLine()));
        Console.WriteLine("結果");
        item.Print();

        Console.Write("更に新しい単価を入力してください -> ");
        item.ChangePrice(Console.ReadLine());
        Console.WriteLine("結果");
        item.Print();

    }
}