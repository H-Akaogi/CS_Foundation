namespace Ex_03_05;

static class Program
{
    static void Main(string[] args)
    {
        ///型数・変数名を設定
        Console.Write("商品番号を入力してください -> ");
        int itemNo = int.Parse(Console.ReadLine()); //ドットの前にインスタンスを付けて呼び出す
        Console.Write("商品名を入力してください -> ");
        string itemName = Console.ReadLine();         //Console.Readは一文字のみ読み取る。
        Console.Write("単価を入力してください -> ");
        int price = int.Parse(Console.ReadLine());

        ///itemの引数の初期値がないため、後ろに設定する
        Item item = new Item(itemNo, itemName, price);
        item.Print();
    }
}

