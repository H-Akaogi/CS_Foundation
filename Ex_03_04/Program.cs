namespace Ex_03_04;

static class Program
{
    static void Main(string[] args)
    {
        Item item = new Item();

        Console.Write("商品番号を入力してください -> ");
        item.itemNo = int.Parse(Console.ReadLine());
        Console.Write("商品名を入力してください -> ");
        item.itemName = Console.ReadLine();
        Console.Write("単価を入力してください -> ");
        item.price = int.Parse(Console.ReadLine());
        Console.Write("新しい単価を入力してください -> ");
        item.pprice = int.Parse(Console.ReadLine());

        item.Print();
        item.ChangePrice();
        Console.WriteLine($"税込み金額 = {item.pprice + (item.pprice * item.salesTaxRate)}");
    }
}
