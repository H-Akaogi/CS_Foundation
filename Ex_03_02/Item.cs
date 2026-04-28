namespace Ex_03_02; //namespaceは所属場所（Programと揃える）
/// <summary>
/// 商品情報を表すクラス
/// </summary>
public class Item //ファイル名と揃える
{
    public int itemNo;      //商品番号(フィールド)
    public string itemName; //商品名(フィールド)
    public int price;	    //単価(フィールド)
    public void Print()//itemNo、itemName、priceフィールドの値を出力する。
    {
        Console.WriteLine("結果");
        Console.WriteLine($"商品番号 = {itemNo}");
        Console.WriteLine($"商品名 = {itemName}");
        Console.WriteLine($"単価 = {price}");
    }
}

