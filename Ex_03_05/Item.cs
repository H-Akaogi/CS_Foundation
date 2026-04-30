namespace Ex_03_05; //namespaceは所属場所（Programと揃える）
/// <summary>
/// 商品情報を表すクラス
/// </summary>
public class Item //ファイル名と揃える。クラスの中身は{}でまとめる
{
    //  フィールド一覧
    public int itemNo;      //商品番号(フィールド)
    public string itemName; //商品名(フィールド)
    public int price;       //単価(フィールド)
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="pitemNo"></param>
    /// <param name="pitemName"></param>
    /// <param name="pprice"></param>
    public Item(int pitemNo, string pitemName, int pprice)
    {
        this.itemNo = pitemNo;
        this.itemName = pitemName;
        this.price = pprice;
    }
    /// <summary>
    /// Printメソッド
    /// </summary>
    public void Print()         //itemNo、itemName、priceフィールドの値を出力する。
    {
        Console.WriteLine("結果");
        Console.WriteLine($"商品番号 = {this.itemNo}");
        Console.WriteLine($"商品名 = {this.itemName}");
        Console.WriteLine($"単価 = {this.price}");
    }
}