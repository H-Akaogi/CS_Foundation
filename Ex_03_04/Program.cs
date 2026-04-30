namespace Ex_03_04;

static class Program
{
    static void Main(string[] args)
    {
        Item item = new Item();

        Console.Write("商品番号を入力してください -> ");
        item.itemNo = int.Parse(Console.ReadLine());
        Console.Write("商品名を入力してください -> ");
        item.itemName = Console.ReadLine();         //Console.Readは一文字のみ読み取る。
        Console.Write("単価を入力してください -> ");
        item.price = int.Parse(Console.ReadLine());
        Console.Write("新しい単価を入力してください -> ");
        item.pprice = int.Parse(Console.ReadLine());
        item.ChangePrice();
        item.Print();
        int answer = item.CalculateTaxAmount();     //answerの型を決めて、Itemクラスでメソッドを実行
        Console.WriteLine(answer);                  //処理結果をコンソールに書き出し
    }
}
